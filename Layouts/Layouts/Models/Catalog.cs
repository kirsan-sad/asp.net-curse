using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layouts.Views
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string System { get; set; }
        public int Price { get; set; }

        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Layouts;Integrated Security=True";

        

        public List<Catalog> GetContent(string catalogItem)
        {
            string sqlExpression = $"SELECT * FROM {catalogItem}";
            var listItems = new List<Catalog>();

            int id, price;
            string brand, model, system = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {
                        id = reader.GetInt32(0);
                        brand = reader.GetString(1);
                        model = reader.GetString(2);
                        price = reader.GetInt32(3);

                        if(catalogItem != "Camera" || catalogItem != "Headphones")
                            system = reader.GetString(4); 

                        listItems.Add(new Catalog {Id = id, Brand = brand, Model = model, System = system, Price = price});
                    }
                }

                reader.Close();

                return listItems;
            }
        }
    }
}
