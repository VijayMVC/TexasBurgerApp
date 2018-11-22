using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TexasBurgerApp.Models
{
    public class DB
    {
        private SqlConnection conn;
        
        //Opens connection to the database
        protected SqlConnection GetConnection()
        {
            //Gets the connection info from the Web.config file.
            this.conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TexasBurgerDB"].ConnectionString);

            conn.Open();

            return conn;
        }

        //Releases connection.
        protected void ReleaseConnection()
        {
            this.conn.Close();
        }
    }
}