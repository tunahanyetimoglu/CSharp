using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITYLAYER;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kitapListele();
            kategoriListele();
 
        }
        void kitapListele()

        {
            List<EKITAP> kitaplistesi = BLLKITAP.SelectList();
            dataGridView1.DataSource = kitaplistesi;
            dataGridView1.Columns["KATEGORIID"].Visible = false;

        }

        void kategoriListele()
        {
            List<EKATEGORI> katListesi = BLLKATEGORI.SelectList();
            comboBox1.DataSource = katListesi;
            comboBox1.DisplayMember = "ADI";
            comboBox1.ValueMember = "ID";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EKITAP item = new EKITAP();
            item.ADI = textBox1.Text;
            item.YAZAR = textBox2.Text;
            item.SAYFASAYISI = Convert.ToInt16(textBox3.Text);
            item.KATEGORIID = Convert.ToInt32(comboBox1.SelectedValue);
        }

     
    }
}
