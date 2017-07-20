using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EOGRETIMUYESI
    {
        int _TcNo;
        int _BolumNo;
        string _Ad;
        string _SoyAd;

        public int TcNo
        {
            get
            {
                return _TcNo;
            }

            set
            {
                _TcNo = value;
            }
        }

        public string Ad
        {
            get
            {
                return _Ad;
            }

            set
            {
                _Ad = value;
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

        public string SoyAd
        {
            get
            {
                return _SoyAd;
            }

            set
            {
                _SoyAd = value;
            }
        }
    }
}
