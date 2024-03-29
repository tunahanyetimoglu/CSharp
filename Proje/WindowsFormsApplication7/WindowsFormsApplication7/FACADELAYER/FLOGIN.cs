﻿using ENTITYLAYER;
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
            SqlCommand com = new SqlCommand("SP_INSERT_LOGIN", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            int satir = -1;

            try
            {
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("Kullanıcı Adı : ", item.UserID);
                com.Parameters.AddWithValue(" Şifre  : ", item.Password);
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
        public static ELOGIN Select(int id)
        {
            ELOGIN item = null;
            SqlCommand com = new SqlCommand("SP_SELECT_UNIVERSITE", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = com.ExecuteReader();
            try
            {               
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.Parameters.AddWithValue("Username : ", item.UserID);
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new ELOGIN();
                        item.UserID = Convert.ToInt32(rdr["userID"]);
                        item.Password = Convert.ToInt32(rdr["password"]);

                    }
                }
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
        public Boolean Update(ELOGIN item)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_UPDATE_LOGIN", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;

            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("Kullanıcı Adı : ", item.UserID);
            com.Parameters.AddWithValue(" Şifre  : ", item.Password);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }
        public Boolean Delete(int id)
        {
            Boolean sonuc = false;
            SqlCommand com = new SqlCommand("SP_DELETE_LOGIN", BAGLANTI.Conn);
            if (com.Connection.State != ConnectionState.Open)
                com.Connection.Open();
            com.Parameters.AddWithValue("Kullanıcı Adı : ", id);
            sonuc = com.ExecuteNonQuery() > 0;
            com.Connection.Close();
            return sonuc;
        }

        public static List<ELOGIN> SelectList()
        {
            List<ELOGIN> itemList = null;

            SqlCommand com = new SqlCommand("SP_SELECT_LOGINLIST", BAGLANTI.Conn);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = com.ExecuteReader();

            try
            {

                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
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

            }
            catch
            {
                itemList = null;
            }
            finally
            {
                rdr.Close();
                com.Connection.Close();
            }
            return itemList;
        }
    }
}
