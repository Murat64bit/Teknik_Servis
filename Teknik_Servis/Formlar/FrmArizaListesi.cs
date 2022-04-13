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
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.islemid,
                              CARIAD= x.TBLCARI.ad + " " + x.TBLCARI.soyad,
                              PERSONELAD= x.TBLPERSONEL.ad + " " + x.TBLPERSONEL.soyad,
                               x.gelistarih,
                               x.cikistarih,
                               x.urunserino
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
