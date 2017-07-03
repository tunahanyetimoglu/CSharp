using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class kokbulma2
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double delta;

            Random r = new Random();
            int x, y,d;
            do
            {
                Console.WriteLine("c değerinin min ve max değerlerini giriniz.");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());

                a = r.Next(1, 10);
                b = r.Next(100);
                c = r.Next(x, y);

                delta = b * b - (4 * a * c);


                if (delta < 0.0)
                {
                    Console.WriteLine("Reel kök yok");
                }
                else if (delta == 0.0)
                {
                    double kok = -b / 2 * a;
                    Console.WriteLine("kok : " + kok);

                }
                else
                {
                    double kok1 = (-b - Math.Sqrt(delta)) / 2 * a;
                    double kok2 = (-b + Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("kok 1" + kok1);
                    Console.WriteLine("kok 2" + kok2);

                }
                Console.WriteLine("Devam etmek için 1 , çıkmak için 0");
                d = Convert.ToInt32(Console.ReadLine());


            } while (d != 0);
                      Console.ReadKey();
        }
    }
}
