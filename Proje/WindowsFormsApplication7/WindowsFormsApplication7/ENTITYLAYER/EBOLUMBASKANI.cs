using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EBOLUMBASKANI
    {
        int _BaskanID;
        int _BolumNo;

        public int BaskanID
        {
            get
            {
                return _BaskanID;
            }

            set
            {
                _BaskanID = value;
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
    }
}
