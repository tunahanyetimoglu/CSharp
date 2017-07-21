using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ENTITYLAYER;
using System.Data.SqlClient;

namespace FACADELAYER
{
    class FUNIVERSITE
    {
        public static int Insert(EUNIVERSITE item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_UNIVERSITE", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("Universite Adı : ", item.ADI);
                com.Parameters.AddWithValue("Universite Telefonu : ", item.TELEFONU);
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
        public static EUNIVERSITE Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_UNIVERSITE", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = com.ExecuteReader();

            EUNIVERSITE item = null;

            try
            {

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ADI: ", item.ADI);

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EUNIVERSITE();
                        item.ADI = rdr["ADI"].ToString();
                        item.TELEFONU = Convert.ToInt32(rdr["TELEFONU"]);

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
                rdr.Close();
                com.Connection.Close();
            }
            return item;
        }
        public Boolean Update(EUNIVERSITE item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_UNIVERSITE", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("ADI : ", item.ADI    );
            com.Parameters.AddWithValue(" Telefonu  : ", item.TELEFONU);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_UNIVERSITE", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EUNIVERSITE> SelectList()
        {
            List<EUNIVERSITE> itemList = null;
            try
            {
                SqlCommand com = new SqlCommand("SP_SELECT_UNIVERSITELIST", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EUNIVERSITE>();
                    while (rdr.Read())
                    {
                        EUNIVERSITE item = new EUNIVERSITE();
                        item.ADI = rdr["ADI"].ToString();
                        item.TELEFONU = Convert.ToInt32(rdr["TELEFONU"]);
                        item.UniversiteNo = Convert.ToInt32(rdr["universiteNo"]);
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
