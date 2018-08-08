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

namespace tt_veri3
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

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Oku();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
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
            //                        cell.Style.BackColor = Color.DarkTurquoise;
            //                        break;
            //                    }
            //                }
            //            }
            //        }
            //    }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string Aratxt = textBox2.Text.Trim().ToUpper();

            int j = -1;

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)

            {

                foreach (DataGridViewCell cell in dataGridView1.Cell[11])
                    //foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    //// foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {

                        if (cell.Value != null)

                        {

                            if (cell.Value.ToString().ToUpper() == Aratxt)

                            {

                                cell.Style.BackColor = Color.Yellow;

                                j = 0;

                                break;

                            }
                        }
                    }
                }
            }

            if (j == -1)

            {
                MessageBox.Show("Kayıt bulunamadı!");
            }
        }
    }
}