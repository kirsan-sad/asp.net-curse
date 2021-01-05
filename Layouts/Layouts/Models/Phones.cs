using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layouts.Models
{
    public class Phones : Repository
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string System { get; set; }
        public int Price { get; set; }


        public override List<Repository> GetContent()
        {
            string sqlExpression = $"SELECT * FROM Mobile_Phone";
            //var listItems = new List<Repository>();

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

                        listItems.Add(new Phones { Id = id, Brand = brand, Model = model, System = system, Price = price });
                    }
                }

                reader.Close();

                return listItems;
            }
        }

    }
}
