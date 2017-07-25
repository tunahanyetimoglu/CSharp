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
    class FACILANDERS
    {
        public static int Insert(EACILANDERS item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_ACILANDERS", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ADersKodu  : ", item.ADersKodu);
                com.Parameters.AddWithValue("DersKodu  : ", item.DersKodu);
                com.Parameters.AddWithValue("TCNo  : ", item.TCNo);
                com.Parameters.AddWithValue("DerslikNo : ", item.DerslikNo);
                com.Parameters.AddWithValue("Sube ", item.Sube);
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
        public static EACILANDERS Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_ACILANDERS", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EACILANDERS item = null;
            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ADersKodu  : ", id);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EACILANDERS();
                        item.ADersKodu = Convert.ToInt32(rdr["ADersKodu"]);
                        item.DersKodu = Convert.ToInt32(rdr["DersKodu"]);
                        item.DerslikNo = Convert.ToInt32(rdr["DerslikNo"]);
                        item.TCNo = Convert.ToInt32(rdr["TCNo"]);
                        item.Sube = Convert.ToInt32(rdr["Sube"]);


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
        public Boolean Update(EACILANDERS item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_ACILANDERS", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ADersKodu  : ", item.ADersKodu);
            com.Parameters.AddWithValue("DersKodu  : ", item.DersKodu);
            com.Parameters.AddWithValue("TCNo  : ", item.TCNo);
            com.Parameters.AddWithValue("DerslikNo : ", item.DerslikNo);
            com.Parameters.AddWithValue("Sube ", item.Sube);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_ACILANDERS", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ADersKodu : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EACILANDERS> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_ACILANDERSLIST", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EACILANDERS> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EACILANDERS>();
                    while (rdr.Read())
                    {
                        EACILANDERS item = new EACILANDERS();
                        item.ADersKodu = Convert.ToInt32(rdr["ADersKodu"]);
                        item.DersKodu = Convert.ToInt32(rdr["DersKodu"]);
                        item.DerslikNo = Convert.ToInt32(rdr["DerslikNo"]);
                        item.TCNo = Convert.ToInt32(rdr["TCNo"]);
                        item.Sube = Convert.ToInt32(rdr["Sube"]);
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
