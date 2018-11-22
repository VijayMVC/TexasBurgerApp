using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TexasBurgerApp.Models
{
    public class MenuMapper : DB
    {

        public void CreateNewBurger(MenuModel Menu)
        {
            SqlCommand command = GetConnection().CreateCommand();

            int custID = GetCurrentCust();
            command.CommandType = CommandType.Text;
            command.CommandText =
                @"INSERT INTO BurgerOrder (CustName, CustTable) 
                VALUES (@CustName, @CustTable)";

            string typeName = Menu.Bun.IngName;
            command.Parameters.AddWithValue("@CustName", Menu.CustName);
            command.Parameters.AddWithValue("@CustTable", Menu.TableID);
            SqlDataReader reader = command.ExecuteReader();
            ReleaseConnection();


            InsertIngridient(GetCurrentCust(), Menu.Bun.ID);
            InsertIngridient(GetCurrentCust(), Menu.Meat.ID);

            //Make Cheese Optional
            if(Menu.Cheese != null)
            {
                InsertIngridient(GetCurrentCust(), Menu.Cheese.ID);
            }
        }
        public void InsertIngridient(int custID, int ingID)
        {
            SqlCommand command = GetConnection().CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText =
                @"INSERT INTO FK_Burger_Ing (FK_BurgerOrder, FK_Ingredient) 
                VALUES (@CustID, @ingID)";

            command.Parameters.AddWithValue("@CustID", custID);
            command.Parameters.AddWithValue("@ingID", ingID);
            SqlDataReader reader = command.ExecuteReader();

            ReleaseConnection();
        }
        public int GetCurrentCust()
        {
            SqlCommand command = GetConnection().CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = @"SELECT MAX(ID) AS LastID FROM BurgerOrder";
               

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int custID = (reader["LastID"] != DBNull.Value) ? Convert.ToInt32(reader["LastID"]) : 0;
                    return custID;
                }

            }
            ReleaseConnection();

            return 0;
        }

    }
}