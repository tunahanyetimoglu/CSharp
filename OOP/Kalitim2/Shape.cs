using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
     abstract class Shape
    {
        protected int boy;
        protected int en;

        abstract public int En { set; get; }
        abstract public int Boy { set; get; }

        public Shape(int boy, int en)
        {
            this.boy = boy;
            this.en = en;
        }

        abstract public int Alan();
        abstract public void EkranaYaz();

    }
}
