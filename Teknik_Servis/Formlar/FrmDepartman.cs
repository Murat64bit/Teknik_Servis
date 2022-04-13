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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.id,
                               u.ad,
                               u.aciklama
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl12.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl14.Text = db.TBLPERSONEL.Count().ToString();
        }

        private void smbKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();
            if (txtAd.Text.Length <= 50 && txtAd.Text != "" && richEditControl1.Text.Length >= 1)
            {
                t.ad = txtAd.Text;
                t.aciklama = richEditControl1.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Departman bilgisi başarı ile kayıt edildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Kayıt yapılması planan bilgi kayıt edilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void smbSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarı ile silindi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          

            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.id,
                               u.ad,
                               u.aciklama
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl12.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl14.Text = db.TBLPERSONEL.Count().ToString();
        }

        private void smbGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            deger.ad = txtAd.Text;
            deger.aciklama = richEditControl1.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarı ile güncellendi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.id,
                               u.ad,
                               u.aciklama
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl12.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl14.Text = db.TBLPERSONEL.Count().ToString();
        }

        private void smbListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.id,
                               u.ad,
                               u.aciklama
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl12.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl14.Text = db.TBLPERSONEL.Count().ToString();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("ad").ToString();
            richEditControl1.Text = gridView1.GetFocusedRowCellValue("aciklama").ToString();

        }
    }
}
