using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teknik_Servis.Formlar
{
    public partial class FrmCariİller : Form
    {
        public FrmCariİller()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9N2I8PS;Initial Catalog=TeknikServis;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");


        private void FrmCariİller_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 5);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 10);
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 7);
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 8);

            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.il).
             GroupBy(y => y.il).
             Select(z => new { il = z.Key, TOPLAM = z.Count().ToString() }).ToList();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select il,Count(*) from TBLCARI group by il",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }
    }
}
