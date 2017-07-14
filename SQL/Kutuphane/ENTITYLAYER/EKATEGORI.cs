using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class EKATEGORI : IDisposable
    {
        int _ID;
        string _ADI;

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
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

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
