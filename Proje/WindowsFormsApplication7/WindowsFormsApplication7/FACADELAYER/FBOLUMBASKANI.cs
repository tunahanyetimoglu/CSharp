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
    class FBOLUMBASKANI
    {
        public static int Insert(EBOLUMBASKANI item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_BOLUMBASKANI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("BaskanID  : ", item.BaskanID);
                com.Parameters.AddWithValue("BolumNo  : ", item.BolumNo);

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
        public static EBOLUMBASKANI Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_BOLUMBASKANI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EBOLUMBASKANI item = null;
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
                        item = new EBOLUMBASKANI();
                        item.BaskanID = Convert.ToInt32(rdr["BaskanID"]);
                        item.BolumNo = Convert.ToInt32(rdr["BolumNo"]);


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
        public Boolean Update(EBOLUMBASKANI item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_BOLUMBASKANI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("BaskanID  : ", item.BaskanID);
            com.Parameters.AddWithValue("BolumNo  : ", item.BolumNo);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_BOLUMBASKANI", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("BaskanID : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EBOLUMBASKANI> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_BOLUMBASKANILIST", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EBOLUMBASKANI> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EBOLUMBASKANI>();
                    while (rdr.Read())
                    {
                        EBOLUMBASKANI item = new EBOLUMBASKANI();
                        item.BaskanID = Convert.ToInt32(rdr["BaskanID"]);
                        item.BolumNo = Convert.ToInt32(rdr["BolumNo"]);
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
