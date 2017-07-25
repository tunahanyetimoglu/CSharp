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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ogrenciListele();
        }

        void ogrenciListele()
        {         
            List<EOGRENCI> ogrenciListesi = BLLOGRENCI.SelectList();
            dataGridView1.DataSource = ogrenciListesi;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
