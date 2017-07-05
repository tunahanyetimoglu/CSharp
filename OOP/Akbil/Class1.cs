using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akbil
{
    abstract class Class1
    {

        private string isim;
        private string soyisim;
        private int yas;
        private int abone_id;
        private double kredi;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
        public int Abone_id { get => abone_id; set => abone_id = value; }
        public double Kredi { get => kredi; set => kredi = value; }

        public Class1(int abone_id, string isim, string soyisim, int yas, double kredi)
        {
            this.Abone_id = abone_id;
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Yas = yas;
            this.Kredi = kredi;
        }
        abstract public void krediGuncelle();

        public void yaslandirma(Class1 n)
        {
            n.Yas += 2;
        }

        public void ekranaYaz()
        {
            Console.WriteLine("{0} {1} {2}            {3}         {4}",Abone_id,Isim,Soyisim,Yas,Kredi);
        }

    }       
       
    
}
