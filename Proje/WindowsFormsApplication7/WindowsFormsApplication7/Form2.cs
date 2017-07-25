using ENTITYLAYER;
using FACADELAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            if (userId == "")
                MessageBox.Show("Kullancı adı giriniz.");

            using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM OGRENCI, OGRETIMUYESI, DEKANL WHERE DEKANL.dekanID = @userID or OGRETIMUYESI.TcNO  = @userID or OGRENCI.ogrenciNO  = @userID ", BAGLANTI.Conn))
            {
                StrQuer.Parameters.AddWithValue("@userID", userId);
                SqlDataReader rdr = StrQuer.ExecuteReader();

                if (rdr.HasRows)
                {
                    Random r = new Random();
                    ELOGIN item = new ELOGIN();
                    item.UserID = Convert.ToInt32(userId);
                    item.Password = Convert.ToInt32(GenerateNewPassword());
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Geçersiz Kullanıcı adı");
                }
                rdr.Close();

            }
        }
        public string GenerateNewPassword()
        {
            char[] cr = "0123456789".ToCharArray();
            string result = string.Empty;
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                result += cr[r.Next(0, cr.Length - 1)].ToString();
            }
            return result;
        }
    }
}
