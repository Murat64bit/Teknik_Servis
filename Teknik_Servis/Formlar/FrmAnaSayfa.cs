using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis.Formlar
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            kritik.DataSource = (from x in db.TBLURUN
                                 select new
                                 {
                                     x.ad,
                                     x.stoksayi
                                 }).Where(x => x.stoksayi < 30).ToList();

            gridControl2.DataSource = (from y in db.TBLCARI
                                       select new
                                       {
                                           y.ad,
                                           y.soyad,
                                           y.il
                                       }).ToList();

            gridControl4.DataSource = db.urunkate().ToList();

            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLAR.OrderBy(y => y.id)
                         where (x.tarih == bugun)
                         select new
                         {
                             x.baslik,
                             x.icerik
                         });
            gridControl3.DataSource = deger.ToList();

            try
            {
                string[] konu = new string[7];

                string[] ad = new string[7];

                LabelControl[] label = new LabelControl[7] { labelControl1, labelControl2, labelControl3, labelControl4, labelControl5, labelControl6, labelControl7 };

                for (int i = 0; i < 8; i++)

                {

                    konu[i] = db.TBLMESAJ.First(m => m.id == i + 1).konu;

                    ad[i] = db.TBLMESAJ.First(m => m.id == i + 1).adsoyad;

                    label[i].Text = konu[i] + " - " + ad[i];

                }
            }
            catch (Exception)
            {

                
            }
           
        }
    }
}
