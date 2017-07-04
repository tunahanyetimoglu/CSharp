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
            KrediHesabi kh = new KrediHesabi();
            KrediHesabi kh2 = new KrediHesabi(9432, 3500, "Someone");

            kh.setHesapNo(1234);
            kh.kartSahibi = "Tunahan";
            kh.Limit = 999999999.9;

            Console.WriteLine(kh.getHesapNo());
            Console.WriteLine(kh.kartSahibi);
            Console.WriteLine(kh.Limit);

            Console.WriteLine("\n");

            Console.WriteLine(kh2.getHesapNo());
            Console.WriteLine(kh2.kartSahibi);
            Console.WriteLine(kh2.Limit);

            Console.ReadKey();
        }
        
    }                                            
}
