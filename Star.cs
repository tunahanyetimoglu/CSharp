using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpp
{
    class Star
    {
        static void Main(string[] args)
        {
            ustbas();
            altbas();

            Console.WriteLine("\n");

            sekil2ust();
            sekil2alt();

            Console.WriteLine("\n");


        }

        static void ustbas()
        {
            for (int i = 0; i < 5; i++)
            {


                for (int k = 0; k <= i; k++)
                    Console.Write("*");

                Console.Write("\n");

            }
        }

        static void altbas()
        {
            for (int i = 4; i > 0; i--)
            {
                for (int k = i; k > 0; k--)
                    Console.Write("*");

                Console.Write("\n");
            }
        }

        static void sekil2ust()
        {
            for (int i = 0; i < 5; i += 2)
            {
                for (int j = 0; j < i; j += 2)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k > i; k -= 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }

        static void sekil2alt()
        {
            for (int i = 0; i < 5; i += 2)
            {
                for (int k = 5; k > i + 1; k -= 2)
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
