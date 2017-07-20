using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EOGRENCI
    {
        int _ogrenciNo;
        int _BolumNo;
        int _DanismanID;
        int _kredi;
        string _OgrenciAD;
        string _OgrenciSOYAD;

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

        public int DanismanID
        {
            get
            {
                return _DanismanID;
            }

            set
            {
                _DanismanID = value;
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

        public string OgrenciAD
        {
            get
            {
                return _OgrenciAD;
            }

            set
            {
                _OgrenciAD = value;
            }
        }

        public string OgrenciSOYAD
        {
            get
            {
                return _OgrenciSOYAD;
            }

            set
            {
                _OgrenciSOYAD = value;
            }
        }
    }
}
