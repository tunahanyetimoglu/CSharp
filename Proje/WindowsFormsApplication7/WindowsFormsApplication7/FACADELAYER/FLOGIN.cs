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
    class FLOGIN
    {
        public static int Insert(ELOGIN item)
        {
            int satir = -1;
            try
            {
                SqlCommand com = new SqlCommand("SP_INSERT_LOGIN", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("Kullanıcı Adı : ", item.UserID);
                com.Parameters.AddWithValue(" Şifre  : ", item.Password);
            }
            catch
            {
                satir = -1;
            }
            return satir;
        }
        public static ELOGIN Select(int id)
        {
            ELOGIN item = null;
            try
            {
                SqlCommand com = new SqlCommand("SP_SELECT_UNIVERSITE", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("Username : ", item.UserID);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new ELOGIN();
                        item.UserID = Convert.ToInt32(rdr["userID"]);
                        item.Password = Convert.ToInt32(rdr["password"]);

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

        public static List<ELOGIN> SelectList()
        {
            List<ELOGIN> itemList = null;
            try
            {
                SqlCommand com = new SqlCommand("SP_SELECT_LOGINLIST", BAGLANTI.Conn);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<ELOGIN>();
                    while (rdr.Read())
                    {
                        ELOGIN item = new ELOGIN();
                        item.UserID = Convert.ToInt32(rdr["userID"]);
                        item.Password = Convert.ToInt32(rdr["password"]);
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
