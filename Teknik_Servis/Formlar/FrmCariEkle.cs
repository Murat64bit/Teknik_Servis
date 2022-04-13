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

    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void FrmCariEkle_Load(object sender, EventArgs e)
        {

        }

        private void FrmCariEkle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FrmCariEkle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void FrmCariEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.ad = txtAd.Text;
            t.soyad = txtSoyad.Text;
            t.il = txtil.Text;
            t.ilce = txtilce.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Cari eklemesi başarılı","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
