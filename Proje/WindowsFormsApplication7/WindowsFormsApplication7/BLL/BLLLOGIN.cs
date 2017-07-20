using ENTITYLAYER;
using FACADELAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class BLLLOGIN
    {
        public static int Insert(ELOGIN item)
        {          
                return FLOGIN.Insert(item);          
        }
        public static ELOGIN Select(int _id)
        {
            if (_id > 0)
                return FLOGIN.Select(_id);
            else
                return null;
        }
        public static List<ELOGIN> SelectList()
        {
            return FLOGIN.SelectList();
        }
    }
}
