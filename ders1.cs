using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class ders1
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b;
            double c = 5.0;
            int d = a++;
            int e = ++a;
            int f = Convert.ToInt32(Math.Pow(3, 4));
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A değişkeni ={0} , b degiskeni ={1} , c degiskeni ={2}",a,b,c); //Ekrana Double basmıyor!!
            Console.WriteLine("A değişkeni =" + a + ", b degiskeni =" + b + " ,c degiskeni =" + c);    // Format yazımlarına bak!
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
            Console.WriteLine("f = " + f);
            Console.ReadKey(); 
        }
    }
}
