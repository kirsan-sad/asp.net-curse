using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layouts.Models
{
    public class Headphoneses : Repository
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public override List<Repository> GetContent()
        {
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

                        listItems.Add(new Headphoneses { Id = id, Brand = brand, Model = model, Price = price });
                    }
                }

                reader.Close();
                return listItems;
            }
        }

    }
}
