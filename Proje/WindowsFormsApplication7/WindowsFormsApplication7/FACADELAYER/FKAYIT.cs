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
    class FKAYIT
    {
        public static int Insert(EKAYIT item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_KAYIT", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ADersKodu  : ", item.ADersKodu);
                com.Parameters.AddWithValue("OgrenciNo : ", item.OgrenciNo);

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
        public static EKAYIT Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_KAYIT", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EKAYIT item = null;
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
                        item = new EKAYIT();
                        item.OgrenciNo = Convert.ToInt32(rdr["ogrenciNO"]);                     
                        item.ADersKodu = Convert.ToInt32(rdr["ADersKodu"]);

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
        public Boolean Update(EKAYIT item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_KAYIT", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ADersKodu  : ", item.ADersKodu);
            com.Parameters.AddWithValue("OgrenciNo : ", item.OgrenciNo);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_KAYIT", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ogrenciNO : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EKAYIT> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_KAYITLIST", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EKAYIT> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EKAYIT>();
                    while (rdr.Read())
                    {
                        EKAYIT item = new EKAYIT();
                        item.OgrenciNo = Convert.ToInt32(rdr["ogrenciNO"]);
                        item.ADersKodu = Convert.ToInt32(rdr["ADersKodu"]);
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
