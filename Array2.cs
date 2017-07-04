using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Array2
    {
        static void Main(string[] args)
        {        
            int[] dizi = new int[10];

            yazdir(dizi);

            Console.ReadKey();
        }

        static void yazdir (int[] dizi)
        {
            Random s = new Random();

            for (int k = 0; k < dizi.Length; k++)
                dizi[k] = s.Next(100);

            foreach (int i in dizi)
                Console.WriteLine(i);
        }
    }
}
