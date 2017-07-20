using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EDEKANL
    {
        int _dekanID;
        int _TCNo;

        public int DekanID
        {
            get
            {
                return _dekanID;
            }

            set
            {
                _dekanID = value;
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
    }
}
