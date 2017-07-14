using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = Convert.ToInt32(Console.ReadLine());

          
                for (int i = 0; i < x*2; i += 2)
                {
                    for (int k = x*2; k > i + 1; k -= 2)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i; j += 1)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }

                Console.ReadKey();

            

        }
    }
}
