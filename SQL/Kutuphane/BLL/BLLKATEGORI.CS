using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ENTITYLAYER;
using FACADELAYER;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class BLLKATEGORI
    {
        public static int Insert(EKATEGORI item)
        {
            if (item.ADI != null && item.ADI.Trim().Length >= 0 && item.ID > 0)
            {
                return FKATEGORI.Insert(item);
            }
            else
                return -1;
        }
        public static Boolean Update(EKATEGORI item)
        {
            if (item.ADI != null && item.ADI.Trim().Length >= 0 && item.ID > 0)
            {
                return FKATEGORI.Update(item);
            }
            else
                return false;
        }
        public static Boolean Delete(int _id)
        {
            if (_id > 0)
                return FKATEGORI.Delete(_id);
            else
                return false; 
        }
        public static EKATEGORI Select(int _id)
        {
            if (_id > 0)
                return FKATEGORI.Select(_id);
            else
                return null;

        }
        public static List<EKATEGORI> SelectList()
        {
            return FKATEGORI.SelectList();
        }
    }
}
