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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.cari = int.Parse(txtid.Text);
            t.gelistarih = DateTime.Parse(txtTarih.Text);
            t.personel = short.Parse(txtPersonel.Text);
            t.urunserino = txtSeriNo.Text;
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ürünler başarı ile kayıt edildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
