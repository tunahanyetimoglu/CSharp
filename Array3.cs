using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpp
{
    class Array3
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Console.WriteLine(Toplam());
            Console.WriteLine(Toplam(1, 2, 3));
            Console.WriteLine(Toplam(1, 2, 3, 4));
            Console.WriteLine(Toplam(1, 2, 3, 4, 5));

            Console.ReadKey();
        }

        static int Toplam(params int[] dizi)
        {


            int tpl = 0;
            if (dizi.Length == 0)
                tpl = 0;
            else
                foreach (int index in dizi)
                    tpl += index;
            return tpl;
        }
    }
}
