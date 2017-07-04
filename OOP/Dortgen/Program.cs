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
            Dortgen nesne1 = new Dortgen();
            nesne1.setEn(5);
            nesne1.boy = 10;
            nesne1.EkranaYaz();
            
            Dortgen nesne2 = new Dortgen(5, 15);
            nesne2.EkranaYaz();

            Console.ReadKey();
        }
        
    }                                            
}
