using ENTITYLAYER;
using FACADELAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class BLLOGRENCI
    {
        public static int Insert(EOGRENCI item)
        {
            return FOGRENCI.Insert(item);
        }
        public static EOGRENCI Select(int _id)
        {
            if (_id > 0)
                return FOGRENCI.Select(_id);
            else
                return null;
        }
        public static List<EOGRENCI> SelectList()
        {
            return FOGRENCI.SelectList();
        }
    }
}
