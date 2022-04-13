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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void smbKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t = new TBLFATURADETAY();
            t.urun = txtUrun.Text;
            t.adet = short.Parse(txtAdet.Text);
            t.fiyat = decimal.Parse(txtFiyat.Text);
            t.tutar = decimal.Parse(txtTutar.Text);
            t.faturaid = int.Parse(txtFatura.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Fatura kalemi başarı ile kayıt edildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.faturadetayid,
                               u.urun,
                               u.adet,
                               u.fiyat,
                               u.tutar,
                               u.faturaid
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.faturadetayid,
                               u.urun,
                               u.adet,
                               u.fiyat,
                               u.tutar,
                               u.faturaid
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void txtSira_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void smbListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.faturadetayid,
                               u.urun,
                               u.adet,
                               u.fiyat,
                               u.tutar,
                               u.faturaid
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
