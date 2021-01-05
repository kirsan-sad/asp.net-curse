using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layouts.Models
{
    public class Notebooks : Repository
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string System { get; set; }
        public int Price { get; set; }

        public override List<Repository> GetContent()
        {
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

                        listItems.Add(new Notebooks { Id = id, Brand = brand, Model = model, System = system, Price = price });
                    }
                }

                reader.Close();
                return listItems;
            }
        }

    }
}
