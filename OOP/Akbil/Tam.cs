using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akbil
{
    class Tam:Class1
    {
        public Tam(int abone_id, string isim, string soyisim, int yas, double kredi):base(abone_id,isim,soyisim,yas,kredi)
        {

        }

        public override void krediGuncelle()
        {
         if (Yas < 30)
                {
                    Kredi = Kredi - 1;
                }
                else if (30 <= Yas && Yas < 60)
                {
                    Kredi = Kredi - 2;
                }
                else
                {
                    Kredi = Kredi - 0.5;
                }

        }
    }
}
