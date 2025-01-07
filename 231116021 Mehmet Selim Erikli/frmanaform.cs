using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116021_Mehmet_Selim_Erikli
{
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }

        private void btnKurumsalGiris_Click(object sender, EventArgs e)
        {
            frmKurumsalgiris fr = new frmKurumsalgiris();
            fr.Show();
            this.Hide();
        }

        private void btnMüsteriEkle_Click(object sender, EventArgs e)
        {
            frmmusteriekle fr = new frmmusteriekle();
            fr.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            frmodalar fr = new frmodalar();
            fr.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMüsteriler fr = new frmMüsteriler();
            fr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void frmanaform_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGelirGider fr = new frmGelirGider();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStoklar fr = new frmStoklar();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRadioEysel fr = new frmRadioEysel();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmGazeteler fr = new frmGazeteler();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSifreGuncelle fr = new frmSifreGuncelle();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMesajlar fr = new frmMesajlar();
            fr.Show();
        }
    }
}
