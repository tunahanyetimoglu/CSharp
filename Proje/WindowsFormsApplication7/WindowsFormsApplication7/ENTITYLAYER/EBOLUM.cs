using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EBOLUM
    {
        int _BolumNo;
        int _FakulteNo;
        string _BolumAdı;

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

        public int FakulteNo
        {
            get
            {
                return _FakulteNo;
            }

            set
            {
                _FakulteNo = value;
            }
        }

        public string BolumAdı
        {
            get
            {
                return _BolumAdı;
            }

            set
            {
                _BolumAdı = value;
            }
        }
    }
}
