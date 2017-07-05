using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Ucgen : Shape
    {
        private string tip;
        public Ucgen(string tip,int boy,int en) : base(boy, en)
        {
            this.tip = tip;
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
            }
        }
        public override int Alan()
        {
            return en * boy / 2;
        }
        public override void EkranaYaz()
        {
            Console.WriteLine("En = " + en);
            Console.WriteLine("Boy = " + boy);
            Console.WriteLine("Tip : = " + this.tip);
            Console.WriteLine("Alan = " + Alan());
            Console.WriteLine();
        }
    }
}
