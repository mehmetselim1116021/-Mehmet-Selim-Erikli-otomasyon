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
    public partial class frmMüsteriler : Form
    {
        public frmMüsteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection(@"Data Source=SELIM\SQLEXPRESS;Initial Catalog=EyselPansiyon;Integrated Security=True;");

        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle",baglanti);
            SqlDataReader oku= komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
            }


        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        int id=0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBoxCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskdtxttelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txttckimlik.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtodaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtücretMusteriler.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dategirisMusteriler.Text = listView1.SelectedItems[0].SubItems[9].Text;
            datecikisMusteriler.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dategirisMusteriler.Text);
            DateTime BuyukTarih = Convert.ToDateTime(datecikisMusteriler.Text);
            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;
            ücretlabel.Text = sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(ücretlabel.Text) *500;
            txtücretMusteriler.Text = Ucret.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update MusteriEkle set Adi='" + txtad.Text + "',Soyadi='" + txtsoyad.Text + "',Cinsiyet='" + comboBoxCinsiyet.Text + "',Telefon='" + mskdtxttelefon.Text + "',Mail='" + txtmail.Text + "',TC='" + txttckimlik.Text + "',OdaNo='" + txtodaNo.Text + "',Ucret='" + txtücretMusteriler.Text + "',GirisTarihi='" + dategirisMusteriler.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + datecikisMusteriler.Value.ToString("yyyy-MM-dd") + "' where Musteriid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtodaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            if (txtodaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();

            }

            if (txtodaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            if (txtodaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            if (txtodaNo.Text == "201")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda201", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            if (txtodaNo.Text == "202")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda202", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();

            }

            if (txtodaNo.Text == "203")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda203", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            if (txtodaNo.Text == "204")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda204", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            if (txtodaNo.Text == "301")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda301", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            if (txtodaNo.Text == "302")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda302", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
        }

                private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.Clear();
            comboBoxCinsiyet.Text = "";
            mskdtxttelefon.Clear();
            txtmail.Clear();
            txttckimlik.Clear();
            txtodaNo.Clear();
            txtücretMusteriler.Clear();
            dategirisMusteriler.Text = "";
            datecikisMusteriler.Text = "";
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+txtara.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        
    }
    }
}
//Data Source=SELIM\SQLEXPRESS;Initial Catalog=EyselPansiyon;Integrated Security=True;