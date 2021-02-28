using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OTOMASYON
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            hastabilgileri hastabilgileri = new hastabilgileri();
            this.Hide();
            hastabilgileri.Show();
        }


       
        private void button4_Click(object sender, EventArgs e)
        {
            hastakayit hastakayit = new hastakayit();
            this.Hide();
            hastakayit.Show();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btndrislemleri.BackColor = Color.DarkCyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btndrislemleri.BackColor = Color.LightCyan;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnmuayene.BackColor = Color.DarkCyan;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnmuayene.BackColor = Color.LightCyan;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            btnhastaislemleri.BackColor = Color.DarkCyan;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnhastaislemleri.BackColor = Color.LightCyan;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            btnhastakabul.BackColor = Color.DarkCyan;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnhastakabul.BackColor = Color.LightCyan;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            btncikis.BackColor = Color.DarkCyan;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            btncikis.BackColor = Color.LightCyan;
        }

        private void btndrislemleri_Click(object sender, EventArgs e)
        {
            doktorbilgileri doktorbilgileri = new doktorbilgileri();
            this.Hide();
            doktorbilgileri.Show();
        }
    }
}
