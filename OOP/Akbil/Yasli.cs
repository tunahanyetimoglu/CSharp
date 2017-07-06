using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akbil
{
    class Yasli:Class1
    {
        public Yasli(int abone_id, string isim, string soyisim, int yas, double kredi):base(abone_id,isim,soyisim,yas,kredi)
        {

        }

        public override void krediGuncelle()
        {
                Kredi = Kredi - 0.5;
            }
        }
    }
}
