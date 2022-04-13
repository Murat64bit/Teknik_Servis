using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmUrunListesi fr1;
        private void btnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                if (fr1 == null || fr1.IsDisposed)

                {

                    fr1 = new Formlar.FrmUrunListesi();

                    fr1.MdiParent = this;

                    fr1.Show();

                }

                else

                {

                    fr1.Focus();

                }
            
        }
        Formlar.FrmYeniUrun fr2;

        private void btnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                if (fr2 == null || fr2.IsDisposed)

                {

                    fr2 = new Formlar.FrmYeniUrun();

                   // fr1.MdiParent = this;

                    fr2.Show();

                }

                else

                {

                    fr2.Focus();

                }
            
        }
        Formlar.FrmCategory fr3;
        private void btnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)

            {

                fr3 = new Formlar.FrmCategory();

                fr3.MdiParent = this;

                fr3.Show();

            }

            else

            {

                fr3.Focus();

            }

        
    }
        Formlar.FrmYeniKategori fr4;
        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)

            {

                fr4 = new Formlar.FrmYeniKategori();

           //     fr4.MdiParent = this;

                fr4.Show();

            }

            else

            {

                fr4.Focus();

            }
        }
        Formlar.Frmİstatistik fr5;
        private void btnİstatestik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)

            {

                fr5 = new Formlar.Frmİstatistik();

                fr5.MdiParent = this;

                fr5.Show();

            }

            else

            {

                fr5.Focus();

            }

        }
        Formlar.FrmMarkalar fr6;
        private void btnMarkaist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)

            {

                fr6 = new Formlar.FrmMarkalar();

                fr6.MdiParent = this;

                fr6.Show();

            }

            else

            {

                fr6.Focus();

            }

        }
        Formlar.FrmCariEkle fr9;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr9 == null || fr9.IsDisposed)

            {

                fr9 = new Formlar.FrmCariEkle();

                //     fr4.MdiParent = this;

                fr9.Show();

            }

            else

            {

                fr9.Focus();

            }
        }
        Formlar.FrmCariListesi fr7;

        private void btnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)

            {

                fr7 = new Formlar.FrmCariListesi();

                fr7.MdiParent = this;

                fr7.Show();

            }

            else

            {

                fr7.Focus();

            }
        }
        Formlar.FrmCariİller fr8;
        private void btnCariİlİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)

            {

                fr8 = new Formlar.FrmCariİller();

                fr8.MdiParent = this;

                fr8.Show();

            }

            else

            {

                fr8.Focus();

            }
        }
        Formlar.FrmDepartman fr10;
        private void frmDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)

            {

                fr10 = new Formlar.FrmDepartman();

                fr10.MdiParent = this;

                fr10.Show();

            }

            else

            {

                fr10.Focus();

            }
        }
        Formlar.FrmDepartmanEkle fr11;
        private void FrmYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)

            {

                fr11 = new Formlar.FrmDepartmanEkle();

                //     fr4.MdiParent = this;

                fr11.Show();

            }

            else

            {

                fr11.Focus();

            }
        }
        Formlar.FrmPersonel fr12;
        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)

            {

                fr12 = new Formlar.FrmPersonel();

               fr12.MdiParent = this;

                fr12.Show();

            }

            else

            {

                fr12.Focus();

            }
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Formlar.FrmKurlar fr13;
        private void btnDovizKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)

            {

                fr13 = new Formlar.FrmKurlar();

                fr13.MdiParent = this;

                fr13.Show();

            }

            else

            {

                fr13.Focus();

            }
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("swriter.exe");

        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("scalc.exe");

        }
        Formlar.FrmYoutube fr14;
        private void btnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr13.IsDisposed)

            {

                fr14 = new Formlar.FrmYoutube();

                fr14.MdiParent = this;

                fr14.Show();

            }

            else

            {

                fr14.Focus();

            }
        }
        Formlar.FrmNotlar fr15;
        private void btnAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)

            {

                fr15 = new Formlar.FrmNotlar();

                fr15.MdiParent = this;

                fr15.Show();

            }

            else

            {

                fr14.Focus();

            }
        }
        Formlar.FrmArizaListesi fr16;
        private void btnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr16 == null || fr16.IsDisposed)

            {

                fr16 = new Formlar.FrmArizaListesi();

                fr16.MdiParent = this;

                fr16.Show();

            }

            else

            {

                fr16.Focus();

            }
        }
        Formlar.FrmUrunSatis fr17;
        private void BtnUrunSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr17 == null || fr17.IsDisposed)

            {

                fr17 = new Formlar.FrmUrunSatis();

                //fr17.MdiParent = this;

                fr17.Show();

            }

            else

            {

                fr17.Focus();

            }
        }
        Formlar.FrmSatis fr18;
        private void btnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr18 == null || fr18.IsDisposed)

            {

                fr18 = new Formlar.FrmSatis();

                fr18.MdiParent = this;

                fr18.Show();

            }

            else

            {

                fr18.Focus();

            }
        }
        Formlar.FrmArizaliUrunKaydi fr19;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr19 == null || fr19.IsDisposed)

            {

                fr19 = new Formlar.FrmArizaliUrunKaydi();

                //fr19.MdiParent = this;

                fr19.Show();

            }

            else

            {

                fr19.Focus();

            }
        }
        Formlar.FrmArizaDetay fr20;
        private void btnArizaliUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr20 == null || fr20.IsDisposed)

            {

                fr20 = new Formlar.FrmArizaDetay();

                //fr19.MdiParent = this;

                fr20.Show();

            }

            else

            {

                fr20.Focus();

            }
        }
        Formlar.FrmArizaliDetayListesi fr21;
        private void btnArizaliUrunDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr21 == null || fr21.IsDisposed)

            {

                fr21 = new Formlar.FrmArizaliDetayListesi();

                fr21.MdiParent = this;

                fr21.Show();

            }

            else

            {

                fr21.Focus();

            }
        }
        Formlar.FrmQRKod fr22;

        private void btnQR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr22 == null || fr22.IsDisposed)

            {

                fr22 = new Formlar.FrmQRKod();

               // fr21.MdiParent = this;

                fr22.Show();

            }

            else

            {

                fr22.Focus();

            }
        }
        Formlar.FrmFaturaListesi fr23;
        private void btnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr23 == null || fr23.IsDisposed)

            {

                fr23 = new Formlar.FrmFaturaListesi();

                fr23.MdiParent = this;

                fr23.Show();

            }

            else

            {

                fr23.Focus();

            }
        }
        Formlar.FrmFaturaKalem fr24;
        private void btnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr24 == null || fr24.IsDisposed)

            {

                fr24 = new Formlar.FrmFaturaKalem();

                fr24.MdiParent = this;

                fr24.Show();

            }

            else

            {

                fr24.Focus();

            }
        }
        Formlar.FrmFaturaKalemleri fr25;
        private void btnFaturaSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr25 == null || fr25.IsDisposed)

            {

                fr25 = new Formlar.FrmFaturaKalemleri();

                fr25.MdiParent = this;

                fr25.Show();

            }

            else

            {

                fr25.Focus();

            }
        }
        Formlar.FrmHarita fr26;
        private void btnHaritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr26 == null || fr26.IsDisposed)

            {

                fr26 = new Formlar.FrmHarita();

                fr26.MdiParent = this;

                fr26.Show();

            }

            else

            {

                fr26.Focus();

            }
        }
        Formlar.FrmRapor fr27;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr27 == null || fr27.IsDisposed)

            {

                fr27 = new Formlar.FrmRapor();

               // fr26.MdiParent = this;

                fr27.Show();

            }

            else

            {

                fr27.Focus();

            }
        }
        Formlar.FrmAnaSayfa fr28;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr28 == null || fr28.IsDisposed)

            {

                fr28 = new Formlar.FrmAnaSayfa();

                fr28.MdiParent = this;

                fr28.Show();

            }

            else

            {

                fr28.Focus();

            }
        }

        private void btnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr28 == null || fr28.IsDisposed)

            {

                fr28 = new Formlar.FrmAnaSayfa();

                fr28.MdiParent = this;

                fr28.Show();

            }

            else

            {

                fr28.Focus();

            }
        }
    }
}
