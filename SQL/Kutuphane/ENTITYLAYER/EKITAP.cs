using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class EKITAP : IDisposable
    {
        int _ID;
        string _ADI;
        string _YAZAR;
        short _SAYFASAYISI;
        int _KATEGORIID;
        string _KATEGORIADI;
        DateTime _GMT;
        string _HOSTNAME;

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

        public string YAZAR
        {
            get
            {
                return _YAZAR;
            }

            set
            {
                _YAZAR = value;
            }
        }

        public short SAYFASAYISI
        {
            get
            {
                return _SAYFASAYISI;
            }

            set
            {
                _SAYFASAYISI = value;
            }
        }

        public int KATEGORIID
        {
            get
            {
                return _KATEGORIID;
            }

            set
            {
                _KATEGORIID = value;
            }
        }

        public string KATEGORIADI
        {
            get
            {
                return _KATEGORIADI;
            }

            set
            {
                _KATEGORIADI = value;
            }
        }

        public DateTime GMT
        {
            get
            {
                return _GMT;
            }

            set
            {
                _GMT = value;
            }
        }

        public string HOSTNAME
        {
            get
            {
                return _HOSTNAME;
            }

            set
            {
                _HOSTNAME = value;
            }
        }

       
    }
}
