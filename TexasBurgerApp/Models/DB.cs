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
        protected SqlConnection GetConnection()
        {
            //string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TexasBurger;Integrated Security=True";

            string connString = @"Data Source=DC-1\SQLtexasburger;Initial Catalog=TexasBurger; user id=sa; password=MCBpower123;";

            this.conn = new SqlConnection(connString);

            conn.Open();

            // SqlCommand command = conn.CreateCommand();

            return conn;
        }

        protected void ReleaseConnection()
        {
            this.conn.Close();
        }
    }
}