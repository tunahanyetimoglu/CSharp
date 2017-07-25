using ENTITYLAYER;
using FACADELAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADELAYER
{
    class FOGRENCI
    {
        public static int Insert(EOGRENCI item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_OGRENCI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ogrenciAD  : ", item.OgrenciAD);
                com.Parameters.AddWithValue("ogrenciSOYAD  : ", item.OgrenciSOYAD);
                com.Parameters.AddWithValue("ogrenciNo  : ", item.OgrenciNo);
                com.Parameters.AddWithValue("BolumNo : ", item.BolumNo);
                com.Parameters.AddWithValue("danismanID ", item.DanismanID);
                com.Parameters.AddWithValue("Kredi : ", item.Kredi);
            }
            catch
            {
                satir = -1;
            }
            finally
            {
                com.Connection.Close();
            }
            return satir;
        }
        public static EOGRENCI Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_OGRENCI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EOGRENCI item = null;
            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ogrenciNo  : ", id);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EOGRENCI();
                        item.OgrenciNo = Convert.ToInt32(rdr["ogrenciNO"]);
                        item.BolumNo = Convert.ToInt32(rdr["BolumNo"]);
                        item.OgrenciAD = rdr["ogrenciAD"].ToString();
                        item.OgrenciSOYAD= rdr["ogrenciSOYADI"].ToString();
                        item.DanismanID = Convert.ToInt32(rdr["danismanID"]);
                        item.Kredi = Convert.ToInt32(rdr["kredi"]);

                    }
                }
                rdr.Close();
            }
            catch
            {
                item = null;
            }
            finally
            {
                com.Connection.Close();
            }
            return item;
        }
        public Boolean Update(EOGRENCI item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_OGRENCI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ogrenciAD  : ", item.OgrenciAD);
            com.Parameters.AddWithValue("ogrenciSOYAD  : ", item.OgrenciSOYAD);
            com.Parameters.AddWithValue("ogrenciNo  : ", item.OgrenciNo);
            com.Parameters.AddWithValue("BolumNo : ", item.BolumNo);
            com.Parameters.AddWithValue("danismanID ", item.DanismanID);
            com.Parameters.AddWithValue("Kredi : ", item.Kredi);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_OGRENCI", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ogrenciNO : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EOGRENCI> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_OGRENCILIST", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EOGRENCI> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EOGRENCI>();
                    while (rdr.Read())
                    {
                        EOGRENCI item = new EOGRENCI();
                        item.OgrenciNo = Convert.ToInt32(rdr["ogrenciNo"]);
                        item.BolumNo = Convert.ToInt32(rdr["BolumNo"]);
                        item.OgrenciAD = rdr["OgrenciAD"].ToString();
                        item.OgrenciSOYAD = rdr["OgrenciSOYAD"].ToString();
                        item.DanismanID = Convert.ToInt32(rdr["DanismanID"]);
                        item.Kredi = Convert.ToInt32(rdr["kredi"]);
                        itemList.Add(item);
                    }
                }
                rdr.Close();
            }
            catch
            {
                itemList = null;
            }
            finally
            {
                com.Connection.Close();
            }
            return itemList;
        }
    }
}
    