using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Channels;
using System.Drawing;
using System.Data;

namespace OTOMASYON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.AliceBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.AliceBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NLUJOC1S.SQLEXPRESS;Initial Catalog=SEBNEM_DB;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "Select *.from GIRIS_EKRANI where Kullanıcı Adı=@adi and Sifre =@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi",textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql , connection);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    Form2 fr = new Form2();
                    fr.Show();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hatali Giris");
                
            }
        }

       


    }
}
