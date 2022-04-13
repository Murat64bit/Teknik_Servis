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
    public partial class FrmArizaliDetayListesi : Form
    {
        public FrmArizaliDetayListesi()
        {
            InitializeComponent();
        }

        private void FrmArizaliDetayListesi_Load(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            gridControl1.DataSource = (from x in db.TBLURUNTAKIP
                                      select new
                                      {
                                          x.takipid,
                                          x.serino,
                                          x.tarih,
                                          x.aciklama
                                      }).ToList();
        }
    }
}
