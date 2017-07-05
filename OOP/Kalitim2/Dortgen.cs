using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Dortgen:Shape
    {
        private bool mKareMi;

        public Dortgen(int boy, int en) : base(boy, en)
        {
            karekontrol();
        }
        
        public bool KareMi
        {
            get
            {
                return mKareMi;
            }
        }
        override public int Boy
        {
            get
            {
                return boy;
            }
            set
            {
                Boy = value;
                karekontrol();
            }
        }
        override public int En
        {
            get
            {
                return en;
            }
            set
            {
                Boy = value;
                karekontrol();
            }
        }
            private void karekontrol()
        {
            if (boy == en)
                mKareMi = true;
            else
                mKareMi = false;
        }
        public override int Alan()
        {
            return en * boy;
        }
        public override void EkranaYaz()
        {
            Console.WriteLine("En = " + en);
            Console.WriteLine("Boy = " + boy);
            Console.WriteLine("Kare mi : = " + (KareMi ? "Evet" : "Hayır"));
            Console.WriteLine("Alan = " +Alan());
            Console.WriteLine();

        }


    }
}
