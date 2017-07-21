using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using FACADELAYER;
using BLL;
using System.Data.SqlClient;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            universiteListele();
        }

        void universiteListele()
        {
            List<EUNIVERSITE> universiteListesi = BLLUNIVERSITE.SelectList();
            dataGridView1.DataSource = universiteListesi;

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            label4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            string password = textBox2.Text;
            if (password == "" || userId == "")
                MessageBox.Show("Kullancı adı ve şifre giriniz.");
            else {

                using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM LOGIN WHERE userID= @userID AND password = @password", BAGLANTI.Conn))
                {
                    StrQuer.Parameters.AddWithValue("@userID", userId);
                    StrQuer.Parameters.AddWithValue("@password", password);
                    SqlDataReader rdr = StrQuer.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        MessageBox.Show("Login Success!");
                    }
                    else
                    {
                        MessageBox.Show("invalid login");                   
                    }
                    rdr.Close();
                    
                }
            }
        }
    }
}
