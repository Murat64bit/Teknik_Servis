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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.id,
                               u.ad,
                               u.soyad,
                               u.mail,
                               u.telefon
                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN select new {
                x.id,
                x.ad
                }).ToList();

            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;
            //2.Personel
            ad1 = db.TBLPERSONEL.First(x => x.id == 2).ad;
            soyad1 = db.TBLPERSONEL.First(x => x.id == 2).soyad;
            labelControl4.Text = db.TBLPERSONEL.First(x => x.id == 2).TBLDEPARTMAN.ad;
            labelControl3.Text = ad1 + " " + soyad1;
            labelControl6.Text = db.TBLPERSONEL.First(x => x.id == 2).mail;

            // 1.Personel
            ad2 = db.TBLPERSONEL.First(x => x.id == 1).ad;
            soyad2 = db.TBLPERSONEL.First(x => x.id == 1).soyad;
            labelControl11.Text = db.TBLPERSONEL.First(x => x.id == 1).TBLDEPARTMAN.ad;
            labelControl14.Text = ad2 + " " + soyad2;
            labelControl9.Text = db.TBLPERSONEL.First(x => x.id == 1).mail;

            // 3.Personel
            ad3 = db.TBLPERSONEL.First(x => x.id == 3).ad;
            soyad3 = db.TBLPERSONEL.First(x => x.id == 3).soyad;
            labelControl18.Text = db.TBLPERSONEL.First(x => x.id == 3).TBLDEPARTMAN.ad;
            labelControl20.Text = ad3 + " " + soyad3;
            labelControl16.Text = db.TBLPERSONEL.First(x => x.id == 3).mail;
            // 4.Personel
            ad4 = db.TBLPERSONEL.First(x => x.id == 4).ad;
            soyad4 = db.TBLPERSONEL.First(x => x.id == 4).soyad;
            labelControl24.Text = db.TBLPERSONEL.First(x => x.id == 4).TBLDEPARTMAN.ad;
            labelControl26.Text = ad4 + " " + soyad4;
            labelControl22.Text = db.TBLPERSONEL.First(x => x.id == 4).mail;
        }

        private void smbKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
