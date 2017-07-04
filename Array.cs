using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpp
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            int[] dizi2;
            dizi2 = new int[20];

            Random r = new Random();
            foreach (int i in dizi)
            {
                dizi[i] = r.Next(1, 50);
                Console.WriteLine(dizi[i] + " "); 
            }
            Console.ReadKey();
        }
    }
}
