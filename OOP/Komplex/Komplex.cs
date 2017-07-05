using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Komplex
    {
        private int gercek;
        private int sanal;

        public int Gercek
        {
            get
            {
                return gercek;
            }

            set
            {
                gercek = value;
            }
        }

        public int Sanal
        {
            get
            {
                return sanal;
            }

            set
            {
                sanal = value;
            }
        }

        public Komplex(int gercek,int sanal)
        {
            this.gercek = gercek;
            this.sanal = sanal;
        }

        public Komplex()
        {
            this.gercek = 0;
            this.sanal = 0;
        }

        public Komplex(Komplex n)
        {
            this.gercek = n.gercek;
            this.sanal = n.sanal;
        }

        public void yazdır()
        {
            if (this.sanal > 0)
                Console.WriteLine("{0} + {1} i",this.gercek, this.sanal);
            else
                Console.WriteLine("{0} - {1}i", this.gercek, -this.sanal);
        }

        public static Komplex operator+(Komplex a, Komplex b)
        {
            int r1 = a.gercek + b.gercek;
            int s1 = a.sanal + b.sanal;
            return new Komplex(r1, s1);
        }

        public static bool operator==(Komplex a,Komplex b)
        {
            if (a.sanal == b.sanal && a.gercek == b.gercek)
                return true;
            else
                return false;
        }

        public static bool operator!=(Komplex a,Komplex b)
        {
            return !(a == b);
        }
        
        public static implicit operator int(Komplex a)
        {
            return a.gercek;
        }

   /*   public override bool Equals(Object obj)
        {
            Komplex K = (Komplex)obj;

            if (this.sanal == K.sanal && this.gercek == K.gercek)
                return true;
            else
                return false;
        }  */
    }
}
