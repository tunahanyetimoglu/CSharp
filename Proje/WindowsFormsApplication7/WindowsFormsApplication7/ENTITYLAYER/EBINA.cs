using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class EBINA
    {
        int _BinaNo;
        string _BinaAdi;

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

        public string BinaAdi
        {
            get
            {
                return _BinaAdi;
            }

            set
            {
                _BinaAdi = value;
            }
        }
    }
}
