using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace Teknik_Servis.Formlar
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void listele()
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               k.id,
                               k.ad
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void smbKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.ad = txtAd.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ürün başarı ile kayıt edildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void smbListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("ad").ToString();
        }

        private void smbSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deger = db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Kategori başarı ile silindi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void smbGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deger = db.TBLKATEGORI.Find(id);
            deger.ad = txtAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Kategori başarı ile güncellendi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtid.Text = "";
        }
    }
}
