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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmSatis_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNHARAKET
                           select new
                           {
                               x.haraketid,
                               x.TBLURUN.ad,
                               MUSTERI = x.TBLCARI.ad + " "+x.TBLCARI.soyad,
                               PERSONEL = x.TBLPERSONEL.ad + " " +x.TBLPERSONEL.soyad,
                               x.tarih,
                               x.adet,
                               x.fiyat,
                               x.urunserino
                           };
                gridsatis.DataSource = degerler.ToList();
        }
    }
}
