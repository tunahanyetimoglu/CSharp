using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpp
{
    class KrediHesabi
    {
        int HesapNo;
        double limit;
        string KartSahibi;

        public KrediHesabi()
        {
            Console.WriteLine("Kredi hesabı oluşturuldu\n\n");
          
        }
        public KrediHesabi(int hesapNo, double Limit, string KartSahibi)
        {
            this.HesapNo = hesapNo;
            this.limit = Limit;
            this.KartSahibi = KartSahibi;
        }

        public void setHesapNo(int x)
        {
            this.HesapNo = x;
        }
        public int getHesapNo()
        {
            return this.HesapNo;
        }
        public double Limit
        {
            get
            {
                return limit;
            }
            set
            {
                this.limit = value;
            }
        }
        public string kartSahibi
        {
            get
            {
                return KartSahibi;
            }
            set
            {
                this.KartSahibi = value;
            }
        }
    
        
        
    }
}
