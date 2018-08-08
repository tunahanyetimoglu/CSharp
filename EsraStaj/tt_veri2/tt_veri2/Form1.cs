using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using excel = Microsoft.Office.Interop.Excel;
namespace tt_veri2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ÇORUM Indoor_MSAN.xlsx; Extended Properties='Excel 12.0 Xml;HDR=YES'");
        public void Oku()
        {
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Report1$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            baglanti.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Oku();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if (dataGridView1.Rows[i+3].Cells[3].Value = dataGridView1.Rows[i + 4].Cells[3].Value)
            //    {
            //        Yaz();
            //    }
            //}

        }
        //public void Yaz()
        //{

        //    MessageBox.Show("Show");
        //    baglanti.Open();
        //    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM dataGridView1", baglanti);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    ///dataGridView2.DataSource = dt.DefaultView;
        //    ///
        //    MessageBox.Show("Show 3");
        //    baglanti.Close();
        //    MessageBox.Show("Show 1");
      //  }


        //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
        //{
        //    string str = (dataGridView1.Rows[i].Cells[1]).Value.ToString() + " " + (dataGridView1.Rows[i].Cells[2]).Value.ToString();

        //    for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
        //    {
        //        string str2 = (dataGridView1.Rows[j].Cells[1]).Value.ToString() + " " + (dataGridView1.Rows[j].Cells[2]).Value.ToString();
        //        if (i != j && str == str2)
        //        {
        //            //kontrol edilen satırlardan ikisi aynı ise o satırları aqua rengine çevir...
        //            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
        //            dataGridView1.Rows[j].DefaultCellStyle.BackColor = Color.Aqua;
        //        }
        //    }
        //}
        //}
        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
        //    uygulama.Visible = true;
        //    Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
        //    Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
        //    Microsoft.Office.Interop.Excel.Range Alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
        //}

        private void Button4_Click(object sender, EventArgs e)
            {
                //baglanti.Open();
                //OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM dataGridView1 where Devre_Durum_Açıklama like Abone", baglanti);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //dataGridView2.DataSource = dt.DefaultView;
                //baglanti.Close();
            }

            private void TextBox1_TextChanged_1(object sender, EventArgs e)
            {
                //    string aranan = textBox1.Text.Trim().ToUpper();
                //    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                //    {
                //        foreach (DataGridViewRow row in dataGridView1.Rows)
                //        {
                //            foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                //            {
                //                if (cell.Value != null)
                //                {
                //                    if (cell.Value.ToString().ToUpper() == aranan)
                //                    {
                //                        Yaz();
                //                        break;
                //                    }
                //                }
                //            }
                //        }
                //    }
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
            uygulama.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            Microsoft.Office.Interop.Excel.Range Alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oku();
        }

        private void list_Unique()
        {
            HashSet<string> uniqueList = new HashSet<string>();
            string colNum;
            colNum = dataGridView1.Columns[1].Name;
            for (int i= 0; i < 500; i++)
            {
                uniqueList.Add(dataGridView1.Rows[i].Cells[colNum].Value.ToString());
            }
            int k = 0;
            foreach (var n in uniqueList)
            {
                dataname[k,0].Value = n;
                k++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list_Unique();
        }
    }

    }


