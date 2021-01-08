using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Layouts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Layouts.Controllers
{
    public class CatalogController : Controller
    {

        public const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Layouts;Integrated Security=True";

        public IActionResult Index()
        {
            //var cat = new Repository();
            //ViewBag.Content = Repository.;

            return View();
        }

        public IActionResult Phones()
        {
            var listPhones = new List<Phones>();

            string sqlExpression = $"SELECT * FROM Mobile_Phone";

            int id, price;
            string brand = string.Empty;
            string model = string.Empty;
            string system = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // if there is data
                {
                    while (reader.Read()) // read data line by line
                    {
                        id = reader.GetInt32(0);
                        brand = reader.GetString(1);
                        model = reader.GetString(2);
                        price = reader.GetInt32(3);
                        system = reader.GetString(4);

                        listPhones.Add(new Phones { Id = id, Brand = brand, Model = model, System = system, Price = price });
                    }
                }
            }

            ViewBag.Content = listPhones;
            return View();
        }

        public IActionResult Cameras()
        {
            var listCameras = new List<Cameras>();

            string sqlExpression = $"SELECT * FROM Camera";

            int id, price;
            string brand = string.Empty;
            string model = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        brand = reader.GetString(1);
                        model = reader.GetString(2);
                        price = reader.GetInt32(3);

                        listCameras.Add(new Cameras { Id = id, Brand = brand, Model = model, Price = price });
                    }
                }
            }
            ViewBag.Content = listCameras;
            return View();
        }

        public IActionResult Notebooks()
        {
            var listNotebooks = new List<Notebooks>();

            string sqlExpression = $"SELECT * FROM Notebook";

            int id, price;
            string brand = string.Empty;
            string model = string.Empty;
            string system = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        brand = reader.GetString(1);
                        model = reader.GetString(2);
                        price = reader.GetInt32(3);
                        system = reader.GetString(4);

                        listNotebooks.Add(new Notebooks { Id = id, Brand = brand, Model = model, System = system, Price = price });
                    }
                }
            }

            ViewBag.Content = listNotebooks;
            return View();
        }

        public IActionResult Headphoneses()
        {
            var listHeadphoneses = new List<Headphoneses>();

            string sqlExpression = $"SELECT * FROM Headphones";

            int id, price;
            string brand = string.Empty;
            string model = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        brand = reader.GetString(1);
                        model = reader.GetString(2);
                        price = reader.GetInt32(3);

                        listHeadphoneses.Add(new Headphoneses { Id = id, Brand = brand, Model = model, Price = price });
                    }
                }
            }

            ViewBag.Content = listHeadphoneses;
            return View();
        }
    }
}