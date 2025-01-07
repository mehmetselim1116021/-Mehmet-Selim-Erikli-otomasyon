using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace _231116021_Mehmet_Selim_Erikli
{
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=SELIM\\SQLEXPRESS;Initial Catalog=EyselPansiyon;Integrated Security=True;");

        private void veriler()

            
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);

            }

            baglanti.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["internet"].ToString());
                ekle.SubItems.Add(oku2["Su"].ToString());
                listView2.Items.Add(ekle);

            }
            baglanti.Close();

        }
            private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gida,icecek,Cerezler) values ('" + txtGidalar.Text + "','" + txticecekler.Text + "','" + txtAtistirmaliklar.Text + "')", baglanti);
           komut.ExecuteNonQuery();
            baglanti.Close() ;
            veriler() ;


        }

        private void frmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar (Elektrik,internet,Su) values ('" + txtEnerjitüketim.Text + "','" + txtEthernetTüketim.Text + "','" + txtSuTüketim.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
