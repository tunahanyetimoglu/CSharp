using System;
using System.Data.SqlClient;
using System.Data;
using ENTITYLAYER;
using System.Collections.Generic;


namespace FACADELAYER
{
    public class FKATEGORI
    {
        public static int Insert(EKATEGORI item)
        {
            int satir = -1;
            try
            {
                SqlCommand com = new SqlCommand("SP_INSERT_KATEGORI", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ADI", item.ADI);
                satir = com.ExecuteNonQuery();
            }
            catch
            {
                satir = -1;
            }
            return satir;
        }
        public static Boolean Update(EKATEGORI item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_KATEGORI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ADI", item.ADI);
            com.Parameters.AddWithValue("ID", item.ID);
            sonuc = com.ExecuteNonQuery() > 0 ;

            return sonuc;
        }
        public static Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_KATEGORI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ID", id);
            sonuc = com.ExecuteNonQuery() > 0;

            return sonuc;
        }
        public static EKATEGORI Select(int id)
        {
            EKATEGORI item = null;
            try
            {
                SqlCommand com = new SqlCommand("SP_SELECTE_KATEGORI", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ID", id);
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EKATEGORI();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.ADI = rdr["ADI"].ToString();
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
        public static List<EKATEGORI> SelectList()
        {
            List<EKATEGORI> itemList = null;
            try
            {
                SqlCommand com = new SqlCommand("SP_SELECTE_KATEGORILIST", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EKATEGORI>();
                    while (rdr.Read())
                    {
                        EKATEGORI item = new EKATEGORI();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.ADI = rdr["ADI"].ToString();
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
