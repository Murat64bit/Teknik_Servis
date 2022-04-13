using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
namespace Teknik_Servis.Formlar
{
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            TBLURUN t = new TBLURUN();
            t.ad = txtUrunAd.Text;
            t.marka = txtMarka.Text;
            t.alisfiyat = decimal.Parse(txtAlisFiyat.Text);
            t.satisfiyat = decimal.Parse(txtSatisFiyat.Text);
            t.stoksayi = short.Parse(txtStok.Text);
            t.kategori = byte.Parse(txtKategori.Text);
            db.TBLURUN.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ürünler başarı ile kayıt edildi","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {

        }
      

      

       

        private void FrmYeniUrun_MouseDown_1(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FrmYeniUrun_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void FrmYeniUrun_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
    }
}
