using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OTOMASYON
{
    public partial class hastakayit : Form
    {
        public hastakayit()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hastakayit_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string HASTA_ID = lblhastaid.Text;
            string TC_NO = lbltcno.Text;
            string ADI_SOYADI = lbladsoyad.Text;
            string ANNE_ADI =lblanneadi.Text;
            string BABA_ADI= lblbabaadi.Text;
            string UYRUK=lbluyruk.Text;
            string DOGUM_YERI=lbldogumyeri.Text;
            string DOGUM_TARIHI=lbldogumtarihi.Text;
            string CINSIYETI=lblcinsiyet.Text;
            string TELEFON1=lbltelefon1.Text;
            string TELEFON2=lbltelefon2.Text;
            string ADRES1=lbladres1.Text;
            string ADRES2=lbladres2.Text;
            string MAIL=lblmail.Text;
            string SOSYAL_GUVENCE=lblsosyalguvence.Text;

            SqlConnection con;
            SqlCommand cmd;
            

            con = new SqlConnection("Data Source=LAPTOP-NLUJOC1S\\SQLEXPRESS;Initial Catalog=SEBNEM_DB;Integrated Security=True");
            cmd = new SqlCommand();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM HASTA where HASTA_ID='" + txtbxhastaid + "' AND TC_NO='" + txtbxtcno.Text + "' AND ADI_SOYADI= '"+ txtbxadsoyad.Text + "' AND ANNE_ADI= '" + txtbxanneadi.Text+ "' AND BABA_ADI= '" + txtbxbabaadi.Text + "' AND UYRUK ='" + txtbxuyruk.Text + "' AND DOGUM_TARIHI= '" + dtpdogumtarihi.Text + "'AND DOGUM_YERI= '" + txtbxdogumyeri.Text + "'AND CINSIYET= '" + cmbobxcinsiyet.Text + "'AND TELEFON1= '" + txtbxtelefon1.Text + "'AND TELEFON2= '" + txtbxtelefon2.Text + "'AND ADRES1= '" + txtbxadres1.Text + "'AND ADRES2= '" + txtbxadres2.Text + "'AND MAIL= '" + txtbxmail.Text + "'AND SOSYAL_GUVENCE= '" + cmbxsosyalguvence + "'  ";

            MessageBox.Show("Hasta kaydı oluşturuldu ", "OTOMASYON", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnkaydet.BackColor = Color.AliceBlue;
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

        private void txtbxadres1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NLUJOC1S\\SQLEXPRESS;Initial Catalog=SEBNEM_DB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from HASTA where HASTA_ID=" + txtbxhastaid.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
