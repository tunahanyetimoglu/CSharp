using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EKAYIT
    {
        int _ADersKodu;
        int _ogrenciNo;
        DateTime _tarih;

        public int ADersKodu
        {
            get
            {
                return _ADersKodu;
            }

            set
            {
                _ADersKodu = value;
            }
        }

        public int OgrenciNo
        {
            get
            {
                return _ogrenciNo;
            }

            set
            {
                _ogrenciNo = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
            }
        }
    }
}
