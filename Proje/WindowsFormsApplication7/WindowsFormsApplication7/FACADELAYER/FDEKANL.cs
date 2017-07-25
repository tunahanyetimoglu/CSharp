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
    class FDEKANL
    {
        public static int Insert(EDEKANL item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_DEKANL", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("dekanID  : ", item.DekanID);
                com.Parameters.AddWithValue("TCNo  : ", item.TCNo);
    
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
        public static EDEKANL Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_DEKANL", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EDEKANL item = null;
            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("dekanID  : ", id);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EDEKANL();
                        item.DekanID = Convert.ToInt32(rdr["dekanID"]);
                        item.TCNo = Convert.ToInt32(rdr["TcNO"]);


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
        public Boolean Update(EDEKANL item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_DEKANL", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("dekanID  : ", item.DekanID);
            com.Parameters.AddWithValue("TCNo  : ", item.TCNo);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_DEKANL", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("dekanID  : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EDEKANL> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_DEKANLIST", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EDEKANL> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EDEKANL>();
                    while (rdr.Read())
                    {
                        EDEKANL item = new EDEKANL();
                        item.DekanID = Convert.ToInt32(rdr["dekanID"]);
                        item.TCNo = Convert.ToInt32(rdr["TcNO"]);
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
