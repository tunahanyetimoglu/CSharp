using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EUNIVERSITE
    {
        int _universiteNo;
        int _TELEFONU;       
        string _ADI;

        public int UniversiteNo
        {
            get
            {
                return _universiteNo;
            }

            set
            {
                _universiteNo = value;
            }
        }

        public int TELEFONU
        {
            get
            {
                return _TELEFONU;
            }

            set
            {
                _TELEFONU = value;
            }
        }

        public string ADI
        {
            get
            {
                return _ADI;
            }

            set
            {
                _ADI = value;
            }
        }
    }
}
