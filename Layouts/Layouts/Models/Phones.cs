﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layouts.Models
{
    public class Phones
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string System { get; set; }
        public int Price { get; set; }
    }
}
