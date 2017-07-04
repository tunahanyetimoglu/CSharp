using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpp
{
    class Dortgen
    {
        int En;
        int Boy;

        public Dortgen()
        {
          
        }

        public Dortgen(int En,int Boy) 
        {
            this.En = En;
            this.Boy = Boy;
        }
        public void setEn(int x)
        {
            this.En = x;
        }
        public int getEn()
        {
            return this.En;
        }
        public int boy
        {
            get
            {
                return Boy;
            }
            set
            {
                this.Boy = value;
            }
        }
        public int AlanHesapla()
        {
            int alan = getEn() * boy;
            return alan;
        }
        public void EkranaYaz()
        {
            Console.WriteLine("En = " + getEn() + " cm");
            Console.WriteLine("Boy = " + Boy + " cm");
            Console.WriteLine("Alan = " + AlanHesapla()+"cm'dir\n");
       
        }
    }
}
