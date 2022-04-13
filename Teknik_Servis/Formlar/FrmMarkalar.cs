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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.marka).GroupBy(y => y.marka).
                Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = (from x in db.TBLURUN
                                   select x.marka).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.TBLURUN
                                   orderby x.satisfiyat descending
                                   select x.marka).FirstOrDefault();
            chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 5);
            chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 6);
            chartControl1.Series["Series 1"].Points.AddPoint("Beko", 7);
            chartControl1.Series["Series 1"].Points.AddPoint("Grundig", 8);
            chartControl1.Series["Series 1"].Points.AddPoint("Xiamoi", 9);
            chartControl1.Series["Series 1"].Points.AddPoint("Samsung", 10);

            chartControl2.Series["Kategoriler"].Points.AddPoint("Küçük Ev Aleti", 11);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 7);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Elektronik", 10);

        }
    }
}
