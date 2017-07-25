using ENTITYLAYER;
using FACADELAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7.FACADELAYER
{
    class FFAKULTE
    {
        public static int Insert(EFAKULTE item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_FAKULTE", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("universiteNo  : ", item.UniversiteNo);
                com.Parameters.AddWithValue("FakulteNo  : ", item.FakulteNo);
            
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
        public static EFAKULTE Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_FAKULTE", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EFAKULTE item = null;
            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("FakulteNo  : ", id);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EFAKULTE();
                        item.FakulteNo = Convert.ToInt32(rdr["FakulteNo"]);
                        item.UniversiteNo = Convert.ToInt32(rdr["universiteNo"]);


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
        public Boolean Update(EFAKULTE item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_FAKULTE", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("universiteNo  : ", item.UniversiteNo);
            com.Parameters.AddWithValue("FakulteNo  : ", item.FakulteNo);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_FAKULTE", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("FakulteNO : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EFAKULTE> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_FAKULTELIST", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EFAKULTE> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EFAKULTE>();
                    while (rdr.Read())
                    {
                        EFAKULTE item = new EFAKULTE();
                        item.FakulteNo = Convert.ToInt32(rdr["FakulteNo"]);
                        item.UniversiteNo = Convert.ToInt32(rdr["universiteNo"]);
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
