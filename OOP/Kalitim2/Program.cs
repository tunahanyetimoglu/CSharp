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
            Shape[] sekiller = new Shape[3];

            sekiller[0] = new Ucgen("Eskenar", 6, 5);
            sekiller[1] = new Dortgen(8, 10);
            sekiller[2] = new Dortgen(4, 4);

            foreach(Shape i in sekiller)
            {
                i.EkranaYaz();
            }
            Console.ReadKey();
        }
    }
}
