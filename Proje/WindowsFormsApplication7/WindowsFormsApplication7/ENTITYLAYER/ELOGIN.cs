using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    class ELOGIN
    {
        int _userID;
        int _password;

        public int Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public int UserID
        {
            get
            {
                return _userID;
            }

            set
            {
                _userID = value;
            }
        }
    }
}
