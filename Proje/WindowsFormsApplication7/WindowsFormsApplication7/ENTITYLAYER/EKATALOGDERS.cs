using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EKATALOGDERS
    {
        int _DersKodu;
        int _BolumNo;
        string _DersAdi;
        int _kredi;

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

        public int BolumNo
        {
            get
            {
                return _BolumNo;
            }

            set
            {
                _BolumNo = value;
            }
        }

        public string DersAdi
        {
            get
            {
                return _DersAdi;
            }

            set
            {
                _DersAdi = value;
            }
        }

        public int Kredi
        {
            get
            {
                return _kredi;
            }

            set
            {
                _kredi = value;
            }
        }
    }
}
