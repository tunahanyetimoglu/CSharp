using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EDerslik
    {
        int _DerslikNo;
        int _BinaNo;

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

        public int BinaNo
        {
            get
            {
                return _BinaNo;
            }

            set
            {
                _BinaNo = value;
            }
        }
    }
}
