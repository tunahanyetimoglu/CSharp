using ENTITYLAYER;
using FACADELAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class BLLUNIVERSITE
    {
        public static int Insert(EUNIVERSITE item)
        {
            if (item.ADI != null)
                return FUNIVERSITE.Insert(item);
            else
                return -1;
        }
        public static EUNIVERSITE Select(int _id)
        {
            if (_id > 0)
                return FUNIVERSITE.Select(_id);
            else
                return null;
        }
        public static List<EUNIVERSITE> SelectList()
        {
            return FUNIVERSITE.SelectList();
        }
    }
}
