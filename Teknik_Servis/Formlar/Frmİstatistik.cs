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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORI.Count().ToString();
            labelControl5.Text = "10";
            labelControl7.Text = db.TBLURUN.Sum(x => x.stoksayi).ToString();

            labelControl19.Text = (from x in db.TBLURUN
                                   orderby x.stoksayi descending
                                   select x.ad).FirstOrDefault();
            labelControl17.Text = (from x in db.TBLURUN
                                   orderby x.stoksayi ascending
                                   select x.ad).FirstOrDefault();
            labelControl13.Text = (from x in db.TBLURUN
                                   orderby x.satisfiyat descending
                                   select x.ad).FirstOrDefault(); 
            labelControl11.Text = (from x in db.TBLURUN
                                   orderby x.satisfiyat ascending
                                   select x.ad).FirstOrDefault();
            labelControl25.Text = db.TBLURUN.Count(x => x.kategori == 3).ToString();
            labelControl29.Text = db.TBLURUN.Count(x => x.kategori == 2).ToString();
            labelControl21.Text = db.TBLURUN.Count(x => x.kategori == 4).ToString();
            labelControl35.Text = (from x in db.TBLURUN
                                   select x.marka).Distinct().Count().ToString();
        }
    }
}
