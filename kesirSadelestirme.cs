using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class kesirSadelestirme
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pay ve payda giriniz.");
            int pay = Convert.ToInt32(Console.ReadLine());
            int payda = Convert.ToInt32(Console.ReadLine());

            refine(pay, payda);
            Console.ReadKey();
        }

        static void refine(int pay,int payda)
        {
            int obeb = gcd(pay, payda);
            pay = pay / obeb;
            payda = payda / obeb;

            Console.WriteLine("\n"+pay + "\n---\n" + payda);
        }

        static int gcd(int pay , int payda)
        {
            int obeb = 0;
            int min = 0;

            if (pay == payda)
                obeb = pay;
            else if (pay < payda)
                min = pay;
            else
                min = payda;

            int i;
            i = min;

            while(i >=2 &&(pay %i != 0 || payda %i != 0))
            {
                i--;
            }

            obeb = i;

            return obeb;
        }
    }
}
