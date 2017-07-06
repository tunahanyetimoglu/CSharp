using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApplication
{
    class Pencere:Form
    {
        private Button hesapla,temizle;
        private RadioButton r1,r2,r3,r4;
        private TextBox t1, t2,t3;
        private Label s1,s2,sonuc;
        private GroupBox gb;

        public Pencere(int x,int y)
        {

            initialize(x,y);
   
        }

        void initialize(int a, int b)
        {
            SetBounds(0, 0, a, b);
            Text = "Hesap Makinesi v.1";

            s1 = new Label();
            s1.Text = "Sayi 1";
            s1.SetBounds(10, 10, 42, 30);
            Controls.Add(s1);

            s2 = new Label();
            s2.Text = "Sayi 2";
            s2.SetBounds(10, 50, 42, 30);
            Controls.Add(s2);

            sonuc = new Label();
            sonuc.Text = "Sonuc ";
            sonuc.SetBounds(10, 90, 42, 30);
            Controls.Add(sonuc);

 //////////////////////////////////////////////////////////

            t1 = new TextBox();
            t1.SetBounds(60, 10, 50, 70);
            Controls.Add(t1);

            t2 = new TextBox();
            t2.SetBounds(60, 50, 50, 70);
            Controls.Add(t2);

            t3 = new TextBox();
            t3.SetBounds(60, 90, 50, 70);
            Controls.Add(t3);

////////////////////////////////////////////////////////////////////

            r1 = new RadioButton();
            r1.Text = "Toplama";
            r1.SetBounds(10, 15, 70, 30);

            r2 = new RadioButton();
            r2.Text = "Çıkarma";
            r2.SetBounds(10, 35, 70, 50);

            r3 = new RadioButton();
            r3.Text = "Bölme";
            r3.SetBounds(100, 15, 70, 30);

            r4 = new RadioButton();
            r4.Text = "Bölme";
            r4.SetBounds(100, 35, 70, 50);

////////////////////////////////////////////////////////////////////

            gb = new GroupBox();
            gb.Text = "İşlemler";
            gb.SetBounds(150, 10, 250, 100);
            gb.Controls.Add(r1);
            gb.Controls.Add(r2);
            gb.Controls.Add(r3);
            gb.Controls.Add(r4);
            Controls.Add(gb);

            ////////////////////////////////////////////////////////////////////

            hesapla = new Button();
            hesapla.Text = "Hesapla";
            Controls.Add(hesapla);
            hesapla.SetBounds(10, 150, 80, 50);

            hesapla.Click += Hesapla_Click1;
            

            temizle = new Button();
            temizle.Text = "Temizle";
            Controls.Add(temizle);
            temizle.SetBounds(150, 150, 80, 50);

            temizle.Click += Temizle_Click;


        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
        }

        private void Hesapla_Click1(object sender, EventArgs e)
        {
            t3.Text = " ";
            if (r1.Checked == true && t1.Text != "" && t2.Text != "")
                t3.Text += (Convert.ToInt32(t1.Text) + Convert.ToInt32(t2.Text)).ToString();
            else if (r2.Checked == true && t1.Text != "" && t2.Text != "")
                t3.Text += (Convert.ToInt32(t1.Text) - Convert.ToInt32(t2.Text)).ToString();
            else if (r3.Checked == true && t1.Text != "" && t2.Text != "") 
                t3.Text += (Convert.ToInt32(t1.Text) * Convert.ToInt32(t2.Text)).ToString();
            else if (r4.Checked == true && t1.Text != "" && t2.Text != "")
                t3.Text += (Convert.ToInt32(t1.Text) / Convert.ToInt32(t2.Text)).ToString();
            else
                MessageBox.Show("Lütfen sayı girip işlem seçtiğinizden emin olun!");    
            

        }


    }
}
