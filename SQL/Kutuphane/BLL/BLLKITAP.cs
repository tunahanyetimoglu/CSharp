using ENTITYLAYER;
using FACADELAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class BLLKITAP
    {
        public static int Insert(EKITAP item)
        {
            if (item.ADI != null && item.ADI.Trim().Length >= 0 && item.KATEGORIID > 0 && item.SAYFASAYISI > 0 && item.YAZAR.Trim().Length > 0)
                return FKITAP.Insert(item);
            else
                return -1;
        }
        public static Boolean Update(EKITAP item)
        {
            if (item.ADI != null && item.ADI.Trim().Length >= 0 && item.KATEGORIID > 0 && item.SAYFASAYISI > 0 && item.YAZAR.Trim().Length > 0)
                return FKITAP.Update(item);
            else
                return false;

        }
        public static Boolean Delete(int _id)
        {
            if (_id > 0)
                return FKITAP.Delete(_id);
            else
                return false;
        }
        public static EKITAP Select(int _id)
        {
            if (_id > 0)
                return FKITAP.Select(_id);
            else
                return null;
           
        }
        public static List<EKITAP> SelectList()
        {
            return FKITAP.SelectList();
        }
    }
}
