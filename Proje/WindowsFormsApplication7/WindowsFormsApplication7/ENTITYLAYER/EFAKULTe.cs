using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EFAKULTE
    {
        int _universiteNo;
        int _FakulteNo;

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
    }
}
