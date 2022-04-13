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
    public partial class FrmArizaDetay : Form
    {
        public FrmArizaDetay()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.aciklama = richTextBox1.Text;
            t.serino = txtserino.Text;
            t.tarih = DateTime.Parse(txttarih.Text);
            db.TBLURUNTAKIP.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Arıza detay ile kayıt edildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
