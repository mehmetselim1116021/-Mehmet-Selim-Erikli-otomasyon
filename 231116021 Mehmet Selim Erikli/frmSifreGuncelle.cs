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
    public partial class frmSifreGuncelle : Form
    {
        public frmSifreGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SELIM\SQLEXPRESS;Initial Catalog=EyselPansiyon;Integrated Security=True;");
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update AdminGiris set kullanici='" + txtkullaniciadiguncelle.Text + "',sifre='" + txtparolaguncelle.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
        }
    }
}
