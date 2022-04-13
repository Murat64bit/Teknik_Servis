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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void metot1()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.id,
                               u.ad,
                               u.marka,
                               kategori = u.TBLKATEGORI.ad,
                               u.stoksayi,
                               u.alisfiyat,
                               u.satisfiyat
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            //listeleme
            // var degerler = db.TBLURUN.ToList();,

            lueKategori.Properties.DataSource = db.TBLKATEGORI.ToList();
            metot1();
        }

        private void smbKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.ad = txtUrunAd.Text;
            t.marka = txtMarka.Text;
            t.alisfiyat = decimal.Parse(txtAlisFiyat.Text);
            t.satisfiyat = decimal.Parse(txtSatisFiyat.Text);
            t.stoksayi = short.Parse(txtStok.Text);
            t.durum = false;
            t.kategori = byte.Parse(lueKategori.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ürün başarı ile kayıt edildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var degerler = db.TBLURUN.ToList();
            metot1();
        }

        private void smbGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deger = db.TBLURUN.Find(id);
            deger.ad = txtUrunAd.Text;
            deger.stoksayi = short.Parse(txtStok.Text);
            deger.marka = txtMarka.Text;
            deger.alisfiyat = decimal.Parse(txtAlisFiyat.Text);
            deger.satisfiyat = decimal.Parse(txtSatisFiyat.Text);
            deger.kategori = byte.Parse(lueKategori.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Ürün başarı ile güncellendi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var degerler = db.TBLURUN.ToList();
            metot1();

        }

        private void smbListele_Click(object sender, EventArgs e)
        {
            //listeleme
            var degerler = db.TBLURUN.ToList();
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            txtUrunAd.Text = gridView1.GetFocusedRowCellValue("ad").ToString();
            txtMarka.Text = gridView1.GetFocusedRowCellValue("marka").ToString();
            txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("alisfiyat").ToString();
            txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("satisfiyat").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("stoksayi").ToString();

        }

        private void smbSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Ürün başarı ile silindi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var degerler = db.TBLURUN.ToList();
            metot1();
        }
    }
}
