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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private SqlConnection conn;
        private SqlCommand cmd;

        private void connect()
        {
            conn = new SqlConnection("Data Source=DESKTOP-I4MA6LQ\\SQLEXPRESS;Initial Catalog=kitapevi;User ID=sa;Password=\"mikrolab\"");
            conn.Open();
        }
        private void disconnect()
        {
            conn.Close();
            conn.Dispose();
        }

        void fill()
        {
            listView1.Items.Clear();
            cmd = new SqlCommand("select * from yazarlar", conn);

            try {
                connect();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = rdr["yaid"].ToString();
                        lvi.SubItems.Add(rdr["yazaradi"].ToString());
                        listView1.Items.Add(lvi);
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { disconnect(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
            }
            catch (Exception)
            {

            }
            cmd = new SqlCommand("insert into yazarlar(yazaradi) Values(@yazaradi)");
            cmd.Parameters.AddWithValue("@yazaradi", textBox1.Text);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connect();
            fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                if (listView1.SelectedItems.Count != 0)
                {
                    cmd = new SqlCommand("delete from yazarlar where yaid=@id", conn);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                if (listView1.SelectedItems.Count != 0)
                {
                    cmd = new SqlCommand("update from yazarlar set yazaradi=@yaz where yaid=@id", conn);
                    cmd.Parameters.AddWithValue("@id", listView1.SelectedItems[0].SubItems[0].Text);
                    cmd.Parameters.AddWithValue("@yaz", textBox1.Text);
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
