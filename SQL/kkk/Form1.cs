using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
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
        private void Form1_Load(object sender, EventArgs e)
        {
            fillDataGrid();
            connect();
            yayinEviCall();
            yazarlarCall();
            kategoriCall();
            disconnect();     
        }
        private void fillDataGrid()
        {
            connect();
            String sqlSelectKitaplar = "SELECT * FROM [kitapeviView]";
            SqlDataAdapter adp = new SqlDataAdapter(sqlSelectKitaplar, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            disconnect();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
           
        }
        private void kategoriCall()
        {
            cmd = new SqlCommand("select * from ktgr",conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                    connect();
                SqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.HasRows)
                {
                    DataTable td = new DataTable();
                    td.Load(rdr);
                    comboBox2.DataSource = td;
                    comboBox2.DisplayMember = "Kategori";   //Görüntülenecek şey
                    comboBox2.ValueMember = "kid";         //Üzerinden işlem yapılacak yer
                    comboBox2.Refresh();
                }
                rdr.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void yazarlarCall()
        {
            cmd = new SqlCommand("select * from yazarlar", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                    connect();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    DataTable td = new DataTable();
                    td.Load(rdr);
                    comboBox3.DataSource = td;
                    comboBox3.DisplayMember = "yazaradi";   //Görüntülenecek şey
                    comboBox3.ValueMember = "yaid";         //Üzerinden işlem yapılacak yer
                    comboBox3.Refresh();
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void yayinEviCall()
        {
            cmd = new SqlCommand("select * from yayinevi", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                    connect();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    DataTable td = new DataTable();
                    td.Load(rdr);
                    comboBox1.DataSource = td;
                    comboBox1.DisplayMember = "yayinevi";   //Görüntülenecek şey
                    comboBox1.ValueMember = "yeid";         //Üzerinden işlem yapılacak yer
                    comboBox1.Refresh();
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String selectedYayinevi = comboBox1.SelectedValue.ToString();
            String selectedKtgr = comboBox2.SelectedValue.ToString();
            String selectedYazar = comboBox3.SelectedValue.ToString();
            String kitapAdi = textBox1.Text.ToString();
            String sqlInsertKitap = "insert into stok (kitapadi,yaid,yeid,kid)" +
                "values ('"+kitapAdi+"',"+selectedYayinevi + "," + selectedKtgr +"," +
                selectedYazar +")";
                connect();

            cmd = new SqlCommand(sqlInsertKitap, conn);
            cmd.ExecuteNonQuery();
            disconnect();
            fillDataGrid();
       
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect();
            int row = -1;
            string sqldelKitap = "delete from stok where kitapid =@id";
            cmd = new SqlCommand(sqldelKitap, conn);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                row = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);

            }
            cmd.Parameters.AddWithValue("@id", row);
            cmd.ExecuteNonQuery();
            disconnect();
            fillDataGrid();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            connect();
            dataGridView1.DataSource = null;
            String sqlselectKitap = "select * from kitapeviView where ";

            if (radioButton1.Checked)          
                sqlselectKitap += "[yazaradi] like '%";
            else if (radioButton2.Checked)
                sqlselectKitap += "yayinevi like '%";
            else if (radioButton3.Checked)
                sqlselectKitap += "[Kategori] like '%";
            else
                sqlselectKitap += "[kitapadi] like '%";

            sqlselectKitap += textBox2.Text;
            sqlselectKitap += "%'";

            SqlDataAdapter adp = new SqlDataAdapter(sqlselectKitap, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            disconnect();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            yayinEviCall();
        }
    }
}
