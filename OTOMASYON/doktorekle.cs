using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OTOMASYON
{
    public partial class doktorekle : Form
    {
        public doktorekle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NLUJOC1S.SQLEXPRESS;Integrated Security=True");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doktorekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnkaydet.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnkaydet.BackColor = Color.Red;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnkapat.BackColor = Color.AliceBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnkapat.BackColor = Color.Red;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
