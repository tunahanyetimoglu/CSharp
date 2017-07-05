using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpp
{
    class Program
    {
        static void Main(string[] args)
        {
            Komplex n = new Komplex(3, -5);
            Komplex n2 = new Komplex();
            Komplex n3 = new Komplex(n);
            Komplex n4;

            n4 = n + n3;

            n.yazdır();
            n2.yazdır();
            n3.yazdır();
            n4.yazdır();

            Console.ReadKey();

        }
    }             
}
