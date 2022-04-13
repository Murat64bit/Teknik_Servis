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
    public partial class FrmDepartmanEkle : Form
    {
        public FrmDepartmanEkle()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Length <= 50 && txtAd.Text != "")
            {
                TBLDEPARTMAN t = new TBLDEPARTMAN();
                t.ad = txtAd.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Ürün başarı ile kayıt edildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
