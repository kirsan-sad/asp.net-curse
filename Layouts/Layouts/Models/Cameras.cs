using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Layouts.Models
{
    public class Cameras : Repository
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public override List<Repository> GetContent()
        {
            string sqlExpression = $"SELECT * FROM Camera";

            int id, price;
            string brand = string.Empty;
            string model = string.Empty;

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

                        listItems.Add(new Cameras { Id = id, Brand = brand, Model = model, Price = price });
                    }
                }

                reader.Close();
                return listItems;
            }
        }

    }
}
