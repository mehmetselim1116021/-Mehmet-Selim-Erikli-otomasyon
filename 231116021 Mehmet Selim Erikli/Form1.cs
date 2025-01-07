using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _231116021_Mehmet_Selim_Erikli
{
    public partial class frmKurumsalgiris : Form
    {
        public frmKurumsalgiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SELIM\SQLEXPRESS;Initial Catalog=EyselPansiyon;Integrated Security=True;");
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where kullanici=@kullaniciadi AND sifre=@sifresi ";
                SqlParameter prm1 = new SqlParameter("kullaniciadi", txtkullaniciadi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtparola.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);


                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frmanaform fr = new frmanaform();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hatalı giriş");  
            }
        }
    }
}
