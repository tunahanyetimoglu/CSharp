using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITYLAYER;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FACADELAYER
{
    class FKITAP
    {

        public static int Insert(EKITAP item)
        {
            int satir = -1;
            try
            {
                SqlCommand com = new SqlCommand("SP_INSERT_KITAP", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ADI", item.ADI);
                com.Parameters.AddWithValue("YAZAR", item.YAZAR);
                com.Parameters.AddWithValue("SAYFASAYISI", item.SAYFASAYISI);
                com.Parameters.AddWithValue("KATEGORIID", item.KATEGORIID);
                satir = com.ExecuteNonQuery();
            }
            catch
            {
                satir = -1;
            }
            return satir;
        }
        public static Boolean Update(EKITAP item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_KITAP", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ID", item.ID);
            com.Parameters.AddWithValue("ADI", item.ADI);
            com.Parameters.AddWithValue("YAZAR", item.YAZAR);
            com.Parameters.AddWithValue("SAYFASAYISI", item.SAYFASAYISI);
            com.Parameters.AddWithValue("KATEGORIID", item.KATEGORIID);
            sonuc = com.ExecuteNonQuery() > 0;

            return sonuc;
        }
        public static Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_KITAP", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ID", id);
            sonuc = com.ExecuteNonQuery() > 0;

            return sonuc;
        }
        public static EKITAP Select(int id)
        {
            EKITAP item = null;
            try
            {
                SqlCommand com = new SqlCommand("SP_SELECTE_KITAP", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ID", id);
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EKITAP();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.ADI = rdr["ADI"].ToString();
                        item.GMT = Convert.ToDateTime(rdr["GMT"]);
                        item.HOSTNAME = rdr["HOSTNAME"].ToString();
                        item.YAZAR = rdr["YAZAR"].ToString();
                        item.KATEGORIID = Convert.ToInt32(rdr["KATEGORIID"]);
                        item.SAYFASAYISI = Convert.ToInt16(rdr["SAYFASAYISI"]);
                    }
                }
                rdr.Close();
            }
            catch
            {
                item = null;
            }
            return item;
        }
        public static List<EKITAP> SelectList()
        {
            List<EKITAP> itemList = null;
            try
            {
                SqlCommand com = new SqlCommand("SP_SELECTE_KITAPLIST", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EKITAP>();
                    while (rdr.Read())
                    {
                        EKITAP item = new EKITAP();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.ADI = rdr["ADI"].ToString();
                        item.GMT = Convert.ToDateTime(rdr["GMT"]);
                        item.HOSTNAME = rdr["HOSTNAME"].ToString();
                        item.KATEGORIADI = rdr["KATEGORIADI"].ToString();
                        item.YAZAR = rdr["YAZAR"].ToString();
                        item.KATEGORIID = Convert.ToInt32(rdr["KATEGORIID"]);
                        item.SAYFASAYISI = Convert.ToInt16(rdr["SAYFASAYISI"]);
                        itemList.Add(item);
                    }
                }
                rdr.Close();
            }
            catch
            {
                itemList = null;
            }
            return itemList;
        }
    }
}
