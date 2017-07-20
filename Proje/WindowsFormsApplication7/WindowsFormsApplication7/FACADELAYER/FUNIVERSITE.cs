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
            int satir = -1;
            try
            {
                SqlCommand com = new SqlCommand("SP_INSERT_UNIVERSITE", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("Universite Adı : ", item.ADI);
                com.Parameters.AddWithValue("Universite Telefonu : ", item.TELEFONU);
            }
            catch
            {
                satir = -1;
            }
            return satir;
        }
        public static EUNIVERSITE Select(int id)
        {
            EUNIVERSITE item = null;
            try
            {
                SqlCommand com = new SqlCommand("SP_SELECT_UNIVERSITE", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("ADI: ", item.ADI);

                SqlDataReader rdr = com.ExecuteReader();
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
            return item;
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
