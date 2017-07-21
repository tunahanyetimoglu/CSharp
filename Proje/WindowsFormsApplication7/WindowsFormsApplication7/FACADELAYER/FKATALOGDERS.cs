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
    class FKATALOGDERS
    {
        public static int Insert(EKATALOGDERS item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_KATALOGDERS", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("DersKodu  : ", item.DersKodu);
                com.Parameters.AddWithValue("BolumNo : ", item.BolumNo);
                com.Parameters.AddWithValue("DersAdi ", item.DersAdi);
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
        public static EKATALOGDERS Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_KATALOGDERS", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EKATALOGDERS item = null;
            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("DersKodu  : ", id);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EKATALOGDERS();
                        item.Kredi = Convert.ToInt32(rdr["ogrenciNO"]);
                        item.BolumNo = Convert.ToInt32(rdr["BolumNo"]);
                        item.DersKodu = Convert.ToInt32(rdr["danismanID"]);
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
        public Boolean Update(EKATALOGDERS item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_KATALOGDERS", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("DersKodu  : ", item.DersKodu);
            com.Parameters.AddWithValue("BolumNo : ", item.BolumNo);
            com.Parameters.AddWithValue("DersAdi ", item.DersAdi);
            com.Parameters.AddWithValue("Kredi : ", item.Kredi);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_KATALOGDERS", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("DersKodu : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EKATALOGDERS> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_KATALOGDERS", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EKATALOGDERS> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EKATALOGDERS>();
                    while (rdr.Read())
                    {
                        EKATALOGDERS item = new EKATALOGDERS();
                        item = new EKATALOGDERS();
                        item.Kredi = Convert.ToInt32(rdr["ogrenciNO"]);
                        item.BolumNo = Convert.ToInt32(rdr["BolumNo"]);
                        item.DersKodu = Convert.ToInt32(rdr["danismanID"]);
                        item.Kredi = Convert.ToInt32(rdr["kredi"]);
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
