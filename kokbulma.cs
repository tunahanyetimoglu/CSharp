using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class kokbulma
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double delta;

            a = Convert.ToDouble(Console.ReadLine());
            b= Convert.ToDouble(Console.ReadLine());
            c =  Convert.ToDouble(Console.ReadLine());

            delta = b * b - (4 * a * c);
            if(delta < 0.0)
            {
                Console.WriteLine("Reel kök yok");
            }
            else if(delta == 0.0)
            {
                double kok = -b  / 2 * a;
                Console.WriteLine("Kok : "+kok);
               
            }
            else
            {
                double kok1 = (-b - Math.Sqrt(delta)) / 2 * a;
                double kok2 = (-b + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("kok 1 :" + kok1);
                Console.WriteLine("kok 2 :" + kok2);
          
            }
            Console.ReadKey();
        }
    }
}
