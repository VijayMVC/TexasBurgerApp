using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TexasBurgerApp.Models
{
    public class IngMapper : DB
    {
        public List<IngridientModel> SelectAll()
        {
            List<IngridientModel> ingList = new List<IngridientModel>();

            SqlCommand command = GetConnection().CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = 
                @"SELECT
                    i.ID AS IngridientID,
	                IngName,
	                Cost,
	                Stock,
	                it.ID AS TypeID,
	                TypeName
                FROM Ingredient as i
                INNER JOIN IngType AS it
                ON i.FK_IngType = it.ID";

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ingList.Add
                    (
                        new IngridientModel
                        {
                            ID = (int)reader["IngridientID"],
                            IngName = (string)reader["IngName"],
                            Cost = (int)reader["Cost"],
                            Type = new TypeModel
                            {
                                ID = (int)reader["TypeID"],
                                TypeName = (string)reader["TypeName"]
                            }

                        }
                    );
                }

            }

            ReleaseConnection();

            return ingList;
        }

        public List<IngridientModel> SelectAllWithStock()
        {
            List<IngridientModel> ingList = new List<IngridientModel>();

            SqlCommand command = GetConnection().CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText =
                @"SELECT 
	                i.ID AS IngridientID,
	                IngName,
	                Cost,
	                it.ID AS TypeID,
	                TypeName
                FROM Ingredient as i
                INNER JOIN IngType AS it
                ON i.FK_IngType = it.ID
                INNER JOIN FK_Res_Ing AS fk_ri
                ON fk_ri.FK_Ingredient = i.ID
                INNER JOIN Resturant AS r
                ON fk_ri.FK_Resturant = r.ID
                WHERE r.ID = @id";

            //Set Resturant ID
            int id = 1;

            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ingList.Add
                    (
                        new IngridientModel
                        {
                            ID = (int)reader["IngridientID"],
                            IngName = (string)reader["IngName"],
                            Cost = (int)reader["Cost"],
                            Type = new TypeModel
                            {
                                ID = (int)reader["TypeID"],
                                TypeName = (string)reader["TypeName"]
                            }

                        }
                    );
                }

            }

            ReleaseConnection();

            return ingList;
        }

        public IngridientModel GetIngridient(int id)
        {
            SqlCommand command = GetConnection().CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText =
                @"SELECT 
	                i.ID AS IngridientID,
	                IngName,
	                Cost,
	                it.ID AS TypeID,
	                TypeName
                FROM Ingredient as i
                INNER JOIN IngType AS it
                ON i.FK_IngType = it.ID
                INNER JOIN FK_Res_Ing AS fk_ri
                ON fk_ri.FK_Ingredient = i.ID
                INNER JOIN Resturant AS r
                ON fk_ri.FK_Resturant = r.ID
                WHERE r.ID = @resId
                AND i.ID = @ingID";

            //Set Resturant ID
            int resId = 1;

            command.Parameters.AddWithValue("@resId", resId);
            command.Parameters.AddWithValue("@ingID", id);
            SqlDataReader reader = command.ExecuteReader();

            IngridientModel returnIngridient = new IngridientModel();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    returnIngridient.ID = (int)reader["IngridientID"];
                    returnIngridient.IngName = (string)reader["IngName"];
                    returnIngridient.Cost = (int)reader["Cost"];
                    returnIngridient.Type = new TypeModel
                    {
                        ID = (int)reader["TypeID"],
                        TypeName = (string)reader["TypeName"]
                    };


                }

            }

            ReleaseConnection();

            return returnIngridient;
        }

        public List<IngridientModel> SelectAllBread()
        {
            List<IngridientModel> ingList = new List<IngridientModel>();

            SqlCommand command = GetConnection().CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText =
                @"SELECT 
	                i.ID AS IngridientID,
	                IngName,
	                Cost,
	                it.ID AS TypeID,
	                TypeName
                FROM Ingredient as i
                INNER JOIN IngType AS it
                ON i.FK_IngType = it.ID
                INNER JOIN FK_Res_Ing AS fk_ri
                ON fk_ri.FK_Ingredient = i.ID
                INNER JOIN Resturant AS r
                ON fk_ri.FK_Resturant = r.ID
                WHERE r.ID = @id
                AND it.TypeName = @typeName";

            //Set Resturant ID
            int id = 1;
            string typeName = "Brød";

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@typeName", typeName);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ingList.Add
                    (
                        new IngridientModel
                        {
                            ID = (int)reader["IngridientID"],
                            IngName = (string)reader["IngName"],
                            Cost = (int)reader["Cost"],
                            Type = new TypeModel
                            {
                                ID = (int)reader["TypeID"],
                                TypeName = (string)reader["TypeName"]
                            }

                        }
                    );
                }

            }

            ReleaseConnection();

            return ingList;
        }
        public List<IngridientModel> SelectAllMeat()
        {
            List<IngridientModel> ingList = new List<IngridientModel>();

            SqlCommand command = GetConnection().CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText =
                @"SELECT 
	                i.ID AS IngridientID,
	                IngName,
	                Cost,
	                it.ID AS TypeID,
	                TypeName
                FROM Ingredient as i
                INNER JOIN IngType AS it
                ON i.FK_IngType = it.ID
                INNER JOIN FK_Res_Ing AS fk_ri
                ON fk_ri.FK_Ingredient = i.ID
                INNER JOIN Resturant AS r
                ON fk_ri.FK_Resturant = r.ID
                WHERE r.ID = @id
                AND it.TypeName = @typeName";

            //Set Resturant ID
            int id = 1;
            string typeName = "Kød";

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@typeName", typeName);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ingList.Add
                    (
                        new IngridientModel
                        {
                            ID = (int)reader["IngridientID"],
                            IngName = (string)reader["IngName"],
                            Cost = (int)reader["Cost"],
                            Type = new TypeModel
                            {
                                ID = (int)reader["TypeID"],
                                TypeName = (string)reader["TypeName"]
                            }

                        }
                    );
                }

            }

            ReleaseConnection();

            return ingList;
        }
        public List<IngridientModel> SelectAllCheese()
        {
            List<IngridientModel> ingList = new List<IngridientModel>();

            SqlCommand command = GetConnection().CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText =
                @"SELECT 
	                i.ID AS IngridientID,
	                IngName,
	                Cost,
	                it.ID AS TypeID,
	                TypeName
                FROM Ingredient as i
                INNER JOIN IngType AS it
                ON i.FK_IngType = it.ID
                INNER JOIN FK_Res_Ing AS fk_ri
                ON fk_ri.FK_Ingredient = i.ID
                INNER JOIN Resturant AS r
                ON fk_ri.FK_Resturant = r.ID
                WHERE r.ID = @id
                AND it.TypeName = @typeName";

            //Set Resturant ID
            int id = 1;
            string typeName = "Ost";

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@typeName", typeName);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ingList.Add
                    (
                        new IngridientModel
                        {
                            ID = (int)reader["IngridientID"],
                            IngName = (string)reader["IngName"],
                            Cost = (int)reader["Cost"],
                            Type = new TypeModel
                            {
                                ID = (int)reader["TypeID"],
                                TypeName = (string)reader["TypeName"]
                            }

                        }
                    );
                }

            }

            ReleaseConnection();

            return ingList;
        }
        public List<IngridientModel> SelectAllGreen()
        {
            List<IngridientModel> ingList = new List<IngridientModel>();

            SqlCommand command = GetConnection().CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText =
                @"SELECT 
	                i.ID AS IngridientID,
	                IngName,
	                Cost,
	                it.ID AS TypeID,
	                TypeName
                FROM Ingredient as i
                INNER JOIN IngType AS it
                ON i.FK_IngType = it.ID
                INNER JOIN FK_Res_Ing AS fk_ri
                ON fk_ri.FK_Ingredient = i.ID
                INNER JOIN Resturant AS r
                ON fk_ri.FK_Resturant = r.ID
                WHERE r.ID = @id
                AND it.TypeName = @typeName";

            //Set Resturant ID
            int id = 1;
            string typeName = "Grønt";

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@typeName", typeName);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ingList.Add
                    (
                        new IngridientModel
                        {
                            ID = (int)reader["IngridientID"],
                            IngName = (string)reader["IngName"],
                            Cost = (int)reader["Cost"],
                            Type = new TypeModel
                            {
                                ID = (int)reader["TypeID"],
                                TypeName = (string)reader["TypeName"]
                            }

                        }
                    );
                }

            }

            ReleaseConnection();

            return ingList;
        }
        public List<IngridientModel> SelectAllDressing()
        {
            List<IngridientModel> ingList = new List<IngridientModel>();

            SqlCommand command = GetConnection().CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText =
                @"SELECT 
	                i.ID AS IngridientID,
	                IngName,
	                Cost,
	                it.ID AS TypeID,
	                TypeName
                FROM Ingredient as i
                INNER JOIN IngType AS it
                ON i.FK_IngType = it.ID
                INNER JOIN FK_Res_Ing AS fk_ri
                ON fk_ri.FK_Ingredient = i.ID
                INNER JOIN Resturant AS r
                ON fk_ri.FK_Resturant = r.ID
                WHERE r.ID = @id
                AND it.TypeName = @typeName";

            //Set Resturant ID
            int id = 1;
            string typeName = "Dressing";

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@typeName", typeName);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ingList.Add
                    (
                        new IngridientModel
                        {
                            ID = (int)reader["IngridientID"],
                            IngName = (string)reader["IngName"],
                            Cost = (int)reader["Cost"],
                            Type = new TypeModel
                            {
                                ID = (int)reader["TypeID"],
                                TypeName = (string)reader["TypeName"]
                            }

                        }
                    );
                }

            }

            ReleaseConnection();

            return ingList;
        }


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
            if (Menu.Cheese != null)
            {
                InsertIngridient(GetCurrentCust(), Menu.Cheese.ID);
            }
            //Make Green Optional
            if (Menu.Green != null)
            {
                InsertIngridient(GetCurrentCust(), Menu.Green.ID);
            }
            //Make Dressing Optional
            if (Menu.Dressing != null)
            {
                InsertIngridient(GetCurrentCust(), Menu.Dressing.ID);
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