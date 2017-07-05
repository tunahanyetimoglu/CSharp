using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Canli c = new Canli();           Abstract classtan nesne üretilemez.
            Canli c = new Kedi(12,10,"rus");
            Kedi kedi1 = new Kedi(3,5,"Van");
            Tavsan tavsan1 = new Tavsan(8, 10);

            kedi1.turGoster();
            kedi1.ozellikGoster();
            kedi1.Konus();
            kedi1.HareketEt();

            tavsan1.Konus();
            tavsan1.HareketEt();

            Console.ReadKey();
            
        }
    }
}
