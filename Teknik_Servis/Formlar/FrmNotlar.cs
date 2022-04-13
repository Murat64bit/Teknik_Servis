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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = db.TBLNOTLAR.Where(x => x.okuma == false).ToList();
            gridControl1.DataSource = db.TBLNOTLAR.Where(y => y.okuma == true).ToList();
        }

        private void smbKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLAR t = new TBLNOTLAR();
            t.baslik = txtbaslik.Text;
            t.icerik = txticerik.Text;
            t.okuma = false;
            db.TBLNOTLAR.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Not başarı ile kayıt edildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl2.DataSource = db.TBLNOTLAR.Where(x => x.okuma == false).ToList();
            gridControl1.DataSource = db.TBLNOTLAR.Where(y => y.okuma == true).ToList();
        }

        private void smbListele_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = db.TBLNOTLAR.Where(x => x.okuma == false).ToList();
            gridControl1.DataSource = db.TBLNOTLAR.Where(y => y.okuma == true).ToList();
        }

        private void smbGuncelle_Click(object sender, EventArgs e)
        {
            if (chkDurum.Checked==true)
            {
                int id = int.Parse(txtid.Text);
                var deger = db.TBLNOTLAR.Find(id);
                deger.okuma = true;
                db.SaveChanges();
                XtraMessageBox.Show("Ürün başarı ile güncellendi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl2.DataSource = db.TBLNOTLAR.Where(x => x.okuma == false).ToList();
                gridControl1.DataSource = db.TBLNOTLAR.Where(y => y.okuma == true).ToList();
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView2.GetFocusedRowCellValue("id").ToString();
        }

        private void smbSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deger = db.TBLNOTLAR.Find(id);
            db.TBLNOTLAR.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Not başarı ile silindi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            gridControl2.DataSource = db.TBLNOTLAR.Where(x => x.okuma == false).ToList();
            gridControl1.DataSource = db.TBLNOTLAR.Where(y => y.okuma == true).ToList();
        }
    }
}
