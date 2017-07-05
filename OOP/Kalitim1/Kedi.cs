using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Kedi : Canli
    {
        private string tur;

        public Kedi(int agirlik,int boy, string tur) : base(agirlik, boy)
        {
            this.tur = tur;
        }
        public void turGoster()
        {
            Console.WriteLine("Tur = " + tur);
        }

        public override void Konus()
        {
            Console.WriteLine("\nmeow");
        }

        public override void HareketEt()
        {
            Console.WriteLine("Kedi hareket etti");
        }
    }
}
