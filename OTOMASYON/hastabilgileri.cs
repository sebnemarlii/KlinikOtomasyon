using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OTOMASYON
{
    public partial class hastabilgileri : Form
    {
        public hastabilgileri()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            hastakayit hastakayit = new hastakayit();
            this.Hide();
            hastakayit.Show();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnara_MouseHover(object sender, EventArgs e)
        {
            btnara.BackColor = Color.LightBlue;
        }

        private void btnara_Click(object sender, EventArgs e)
        {

        }

        private void btnara_MouseLeave(object sender, EventArgs e)
        {
            btnara.BackColor = Color.DarkBlue;
        }
    }
}
