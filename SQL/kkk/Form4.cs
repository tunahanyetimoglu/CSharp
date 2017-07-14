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

namespace WindowsFormsApplication5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private SqlConnection conn;
        private SqlCommand cmd;

        void connect()
        {
            conn = new SqlConnection("Data Source=DESKTOP-I4MA6LQ\\SQLEXPRESS;Initial Catalog=kitapevi;User ID=sa;Password=\"mikrolab\"");
            conn.Open();
        }
        void disconnect()
        {
            conn.Close();
            conn.Dispose();
        }

        void fill()
        {
            listView1.Items.Clear();
            cmd = new SqlCommand("select * from yayinevi", conn);

            try
            {
                //connect();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = rdr["yeid"].ToString();
                        lvi.SubItems.Add(rdr["yayinevi"].ToString());
                        listView1.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { disconnect(); }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
            }
            catch (Exception)
            {

            }
            cmd = new SqlCommand("insert into yayinevi(yayinevi) Values(@yayinevi)");
            cmd.Parameters.AddWithValue("@yayinevi", textBox1);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            connect();
            fill();
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                if (listView1.SelectedItems.Count != 0)
                {
                    cmd = new SqlCommand("delete from yayinevi where yeid=@id", conn);
                    cmd.Parameters.AddWithValue("@id", listView1.SelectedItems[0].SubItems[0].Text);
                    cmd.ExecuteNonQuery();
                    fill();
                }
                else
                    MessageBox.Show("Bir seçim yapın");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata var " + ex);
            }
            finally { disconnect(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                if (listView1.SelectedItems.Count != 0)
                {
                    cmd = new SqlCommand("update from yayinevi set yayinevi=@yayev where yeid=@id", conn);
                    cmd.Parameters.AddWithValue("@id", listView1.SelectedItems[0].SubItems[0].Text);
                    cmd.Parameters.AddWithValue("@yayev", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    fill();
                }
                else
                    MessageBox.Show("Bir seçim yapın");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata var " + ex);
            }
            finally { disconnect(); }
        }
    }
}
