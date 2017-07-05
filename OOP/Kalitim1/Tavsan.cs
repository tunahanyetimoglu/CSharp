using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Tavsan : Canli
    {
        public Tavsan(int agirlik,int boy):base(boy,agirlik)
        {
            
        }

        public override void HareketEt()
        {
            Console.WriteLine("Tavsan hareket etti");
        }

        public override void Konus()
        {
            Console.WriteLine("\nqwıeyhuoeqwe");
        }
    }
}
