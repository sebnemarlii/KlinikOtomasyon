using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OTOMASYON
{
    public partial class doktorbilgileri : Form
    {
        public doktorbilgileri()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            doktorekle doktorekle = new doktorekle();
            this.Hide();
            doktorekle.Show();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnara_MouseHover(object sender, EventArgs e)
        {
            btnara.BackColor = Color.LightBlue;
        }

        private void btnara_MouseLeave(object sender, EventArgs e)
        {
            btnara.BackColor = Color.DarkBlue;
        }

        private void btnekle_MouseHover(object sender, EventArgs e)
        {
            btnekle.BackColor = Color.AliceBlue;
        }

        private void btnekle_MouseLeave(object sender, EventArgs e)
        {
            btnekle.BackColor = Color.Red;
        }

        private void btnsil_MouseHover(object sender, EventArgs e)
        {
            btnsil.BackColor = Color.AliceBlue;
        }

        private void btnsil_MouseLeave(object sender, EventArgs e)
        {
            btnsil.BackColor = Color.Red;
        }

        private void btnkapat_MouseHover(object sender, EventArgs e)
        {
            btnkapat.BackColor = Color.AliceBlue;
        }

        private void btnkapat_MouseLeave(object sender, EventArgs e)
        {
            btnkapat.BackColor = Color.Red;
        }
    }
}
