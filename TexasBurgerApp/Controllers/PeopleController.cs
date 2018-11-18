using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TexasBurgerApp.Models;

using System.Data.SqlClient;
using System.Data;

namespace TexasBurgerApp.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {

            //string connString = @"Data Source=DC-1\TEXASBURGER;Initial Catalog=Performance;Integrated Security=True";
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Performance;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            conn.Open();

            SqlCommand command = conn.CreateCommand();

            command.CommandType = CommandType.Text;

            int id = 1;

            //command.CommandText = "Select * FROM random WHERE id = @id";
            command.CommandText = "SELECT TOP 5 id, RandomNumber FROM Random";
            //command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();

            List<PersonModel> people = new List<PersonModel>();

            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    people.Add(new PersonModel { ID = (int)reader["RandomNumber"], RandomNumber = (int)reader["RandomNumber"] });
                }

                //int randomNumber = (int)reader["RandomNumber"];

            }

            return View(people);
        }
    }
}