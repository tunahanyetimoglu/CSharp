using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EACILANDERS
    {
        int _ADersKodu;
        int _DersKodu;
        int _TCNo;
        int _DerslikNo;
        int _Sube;

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

        public int DersKodu
        {
            get
            {
                return _DersKodu;
            }

            set
            {
                _DersKodu = value;
            }
        }

        public int TCNo
        {
            get
            {
                return _TCNo;
            }

            set
            {
                _TCNo = value;
            }
        }

        public int DerslikNo
        {
            get
            {
                return _DerslikNo;
            }

            set
            {
                _DerslikNo = value;
            }
        }

        public int Sube
        {
            get
            {
                return _Sube;
            }

            set
            {
                _Sube = value;
            }
        }
    }
}
