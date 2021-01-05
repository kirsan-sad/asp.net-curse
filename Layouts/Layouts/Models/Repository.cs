using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layouts.Models
{
    public abstract class Repository
    {
        //public int Id { get; set; }
        //public string Brand { get; set; }
        //public string Model { get; set; }
        //public string System { get; set; }
        //public int Price { get; set; }

        public const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Layouts;Integrated Security=True";

        public List<Repository> listItems = new List<Repository>();
        public abstract List<Repository> GetContent();

    }
}
