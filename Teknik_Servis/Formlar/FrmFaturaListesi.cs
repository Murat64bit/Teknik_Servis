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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.id,
                               u.seri,
                               u.sirano,
                               u.tarih,
                               u.saat,
                               u.vergidairesi,
                               CARI = u.TBLCARI.ad + " " + u.TBLCARI.soyad,
                               PERSONEL = u.TBLPERSONEL.ad +" "+ u.TBLPERSONEL.soyad
                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.id,
                                                     AD=x.ad +" " +x.soyad
                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.id,
                                                     AD=x.ad +" " +x.soyad
                                                 }).ToList();
        }

        private void smbKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.seri = txtSeri.Text;
            t.sirano = txtSira.Text;
            t.tarih = Convert.ToDateTime(txtTarih.Text);
            t.saat = txtSaat.Text;
            t.vergidairesi = txtVergiDairesi.Text;
            t.cari = int.Parse(lookUpEdit1.EditValue.ToString());
            t.personel = short.Parse(lookUpEdit2.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Fatura başarı ile kayıt edildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void smbListele_Click(object sender, EventArgs e)
        {

        }
    }
}
