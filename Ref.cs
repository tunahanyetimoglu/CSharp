using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpp
{
    class Ref
    {
        static void Main(string[] args)
        {
            int x = 5, y = 8;

            Console.WriteLine("önce x : {0}   y : {1}", x, y);

            myswap(ref x,ref y);
            
            Console.WriteLine("sonra x : {0}  y : {1}", x, y);
            
            Console.ReadKey();
        }

        static void myswap (ref int x ,ref int y)
        {
            x = y - x;
            y = y - x;
            x = x + y;
        }
    }
}
