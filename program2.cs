using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program2
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for (int k = x; x > 0; x--) {
                for (int i = x; i > 0; i--)
                {
                    Console.Write(i);
                }
                for (int i = 2; i < x + 1; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
