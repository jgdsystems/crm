using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace crm.dao
{

    /// <summary>
    /// Descrição resumida de DAO
    /// </summary>
    public static class DAO
    {
        /// <summary>
        /// Get Connection
        /// </summary>
        public static MySqlConnection Connection()
        {
           
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            //Ambiente de desenvolvimento
           myConnectionString = "server=localhost;uid=xxxx;pwd=xxxx;database=xxxx";

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            return conn;
          

        }

        /// <summary>
        /// User verify
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns>boolean value</returns>
        public static Boolean isUser(String user, String password)
        {
            Boolean response = false;
            //abre a conexao
            MySqlConnection mConn = Connection();
            mConn.Open();
            try
            {
                //verificva se a conexão esta aberta
                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    string sql = @"select count(*) total from crmdb01.users where email = '" + user+"' and password = '"+password+"'";
                    cmd.CommandText = sql;
                    cmd.Connection = mConn;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int total = reader.GetInt32(0);
                            if (total > 0)
                            {
                                response = true;
                            }
                            
                        }
                        reader.Close();
                    }
                }

                return response;
            }
            catch (Exception)
            {
                mConn.Close();
                return response;
            }
        }


    }
}