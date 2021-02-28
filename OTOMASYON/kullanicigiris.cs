using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace OTOMASYON
{
    public partial class kullanicigiris : Form
    {
        public kullanicigiris()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        SqlConnection connection= new SqlConnection("Data Source=LAPTOP-NLUJOC1S\\SQLEXPRESS;Initial Catalog=SEBNEM_DB;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string KULLANICI_ADI = lblkullaniciadi.Text;
            string SIFRE = lblsifre.Text;
            con = new SqlConnection("Data Source=LAPTOP-NLUJOC1S\\SQLEXPRESS;Initial Catalog=SEBNEM_DB;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM GIRIS_EKRANI where KULLANICI_ADI='" + txtbxkullaniciadi.Text + "' AND SIFRE='" + txtbxsifre.Text + "'";
               
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                anamenu frm = new anamenu();
                this.Hide();
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalı lütfen kontrol ediniz.");
            }
            con.Close();

        }

        private void txtbxsifre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtsifre_Click(object sender, EventArgs e)
        {
           
        }

        private void kullanicigiris_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnkapat_MouseHover(object sender, EventArgs e)
        {
            btnkapat.BackColor = Color.AliceBlue;
        }

        private void btnkapat_MouseLeave(object sender, EventArgs e)
        {
            btnkapat.BackColor = Color.Red;
        }

        private void btngiris_MouseHover(object sender, EventArgs e)
        {
            btngiris.BackColor = Color.AliceBlue;
        }

        private void btngiris_MouseLeave(object sender, EventArgs e)
        {
            btngiris.BackColor = Color.Red;
        }
    }
}
