using ENTITYLAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADELAYER
{
    class FDerslik
    {
        public static int Insert(EDerslik item)
        {
            SqlCommand com = new SqlCommand("SP_INSERT_Derslik", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("DerslikNo  : ", item.DerslikNo);
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
        public static EDerslik Select(int id)
        {
            SqlCommand com = new SqlCommand("SP_SELECT_Derslik", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            EDerslik item = null;
            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("DerslikNo  : ", item.DerslikNo);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EDerslik();
                        item.DerslikNo = Convert.ToInt32(rdr["DerslikNo"]);
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
        public Boolean Update(EDerslik item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_Derslik", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("DerslikNo  : ", item.DerslikNo);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_Derslik", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("DerslikNo  : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public static List<EDerslik> SelectList()
        {
            SqlCommand com = new SqlCommand("SP_SELECT_DerslikLIST", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            List<EDerslik> itemList = null;
            try
            {


                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EDerslik>();
                    while (rdr.Read())
                    {
                        EDerslik item = new EDerslik();
                        item.DerslikNo = Convert.ToInt32(rdr["DerslikNo"]);
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
