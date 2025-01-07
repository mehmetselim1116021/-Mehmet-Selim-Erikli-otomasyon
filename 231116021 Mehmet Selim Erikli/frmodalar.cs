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
    public partial class frmodalar : Form
    {
        public frmodalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SELIM\\SQLEXPRESS;Initial Catalog=EyselPansiyon;Integrated Security=True;");

        private void frmodalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btn101.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btn101.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btn201.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn201.Text != "201")
            {
                btn201.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btn202.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn202.Text != "202")
            {
                btn202.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda203", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btn203.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn203.Text != "203")
            {
                btn203.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda204", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btn204.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn204.Text != "204")
            {
                btn204.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda301", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btn301.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn301.Text != "301")
            {
                btn301.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("select * from Oda302", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();

            while (oku11.Read())
            {
                btn302.Text = oku11["Adi"].ToString() + " " + oku11["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn302.Text != "302")
            {
                btn302.BackColor = Color.Red;
            }
        }
    }
}
            
        
