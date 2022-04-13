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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNHARAKET t = new TBLURUNHARAKET();
            t.urun = int.Parse(txtid.Text);
            t.musteri = int.Parse(txtMusteri.Text);
            t.personel = short.Parse(txtPersonel.Text);
            t.tarih = DateTime.Parse(txtTarih.Text);
            t.adet = short.Parse(txtAdet.Text);
            t.fiyat = decimal.Parse(txtFiyat.Text);
            t.urunserino = txtSeriNo.Text;
            db.TBLURUNHARAKET.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ürün satışı başarı ile kayıt edildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
