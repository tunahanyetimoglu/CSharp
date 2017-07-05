using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    abstract class Canli    // sealed koyulursa miras alınamaz(türetilemez) hale gelir
         
    {
        abstract public void HareketEt();

        public int boy;
        public int agirlik;

       

        public Canli(int boy,int agirlik)
        {
            this.boy = boy;
            this.agirlik = agirlik;
        }
        public Canli()
        {
            this.boy = 0;
            this.agirlik = 0;
        }

        public void ozellikGoster()
        {
            Console.WriteLine("Boy : " + boy);
            Console.WriteLine("Agirlik : " + agirlik);

        }

        virtual public void Konus()
        {
            Console.WriteLine("Ne vereyim abime");
        }
   
      
    }
}
