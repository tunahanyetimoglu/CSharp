using ENTITYLAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADELAYER
{
    class FOGRETIMUYESI
    {
        public static int Insert(EOGRETIMUYESI item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_OGRETIMUYESI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("TcNO  : ", item.TcNo);
                com.Parameters.AddWithValue("BolumNo : ", item.BolumNo);
                com.Parameters.AddWithValue("ADI: ", item.Ad);
                com.Parameters.AddWithValue("SoyADI: ", item.SoyAd);
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
        public static EOGRETIMUYESI Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_OGRETIMUYESI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EOGRETIMUYESI item = null;
            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("TcNo: ", item.TcNo);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EOGRETIMUYESI();
                        item.TcNo = Convert.ToInt32(rdr["TcNO"]);
                        item.BolumNo = Convert.ToInt32(rdr["BolumNo"]);
                        item.Ad = rdr["ADI"].ToString();
                        item.SoyAd = rdr["SOYADI"].ToString();

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
        public Boolean Update(EOGRETIMUYESI item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_OGRETIMUYESI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("TcNO  : ", item.TcNo);
            com.Parameters.AddWithValue("BolumNo : ", item.BolumNo);
            com.Parameters.AddWithValue("ADI : ", item.Ad);
            com.Parameters.AddWithValue("SoyADI: ", item.SoyAd);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_OGRETIMUYESI", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("TcNO : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EOGRETIMUYESI> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_OGRETIMUYESI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EOGRETIMUYESI> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EOGRETIMUYESI>();
                    while (rdr.Read())
                    {
                        EOGRETIMUYESI item = new EOGRETIMUYESI();
                        item.TcNo = Convert.ToInt32(rdr["TcNO"]);
                        item.BolumNo = Convert.ToInt32(rdr["BolumNo"]);
                        item.Ad = rdr["ADI"].ToString();
                        item.SoyAd = rdr["SOYADI"].ToString();
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
