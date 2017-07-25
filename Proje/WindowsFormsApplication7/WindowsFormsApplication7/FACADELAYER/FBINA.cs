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
    class FBINA
    {
        public static int Insert(EBINA item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_BINA", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("BinaAdi  : ", item.BinaAdi);
                com.Parameters.AddWithValue("BinaNo  : ", item.BinaNo);
                
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
        public static EBINA Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_BINA", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EBINA item = null;
            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("BinaNo  : ", id);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EBINA();                    
                        item.BinaAdi = rdr["BinaAdi"].ToString();
                        item.BinaNo = Convert.ToInt32(rdr["BinaNo"]);
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
        public Boolean Update(EBINA item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_BINA", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("BinaAdi  : ", item.BinaAdi);
            com.Parameters.AddWithValue("BinaNo  : ", item.BinaNo);

            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_BINA", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("BinaNo : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EBINA> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_BINALIST", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EBINA> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EBINA>();
                    while (rdr.Read())
                    {
                        EBINA item = new EBINA();
                        item.BinaAdi = rdr["BinaAdi"].ToString();
                        item.BinaNo = Convert.ToInt32(rdr["BinaNo"]);
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
