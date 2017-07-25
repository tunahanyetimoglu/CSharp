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
    class FBOLUM
    {
        public static int Insert(EBOLUM item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_OGRENCI", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("FakulteNo  : ", item.FakulteNo);
                com.Parameters.AddWithValue("BolumAdı  : ", item.BolumAdı);
                com.Parameters.AddWithValue("BolumNo : ", item.BolumNo);

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
        public static EBOLUM Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_BOLUM", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EBOLUM item = null;
            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("BolumNo  : ", id);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EBOLUM();
                        item.FakulteNo = Convert.ToInt32(rdr["ogrenciNO"]);
                        item.BolumNo = Convert.ToInt32(rdr["BolumNo"]);
                        item.BolumAdı = rdr["BolumAdı"].ToString();


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
        public Boolean Update(EBOLUM item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_BOLUM", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("FakulteNo  : ", item.FakulteNo);
            com.Parameters.AddWithValue("BolumAdı  : ", item.BolumAdı);
            com.Parameters.AddWithValue("BolumNo : ", item.BolumNo);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_BOLUM", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("BolumNo : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EBOLUM> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_BOLUMLIST", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EBOLUM> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EBOLUM>();
                    while (rdr.Read())
                    {
                        EBOLUM item = new EBOLUM();
                        item.FakulteNo = Convert.ToInt32(rdr["ogrenciNO"]);
                        item.BolumNo = Convert.ToInt32(rdr["BolumNo"]);
                        item.BolumAdı = rdr["BolumAdı"].ToString();
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
