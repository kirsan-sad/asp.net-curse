using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Converter.Controllers
{
    public class ValidationTemp
    {
        public int TempF { get; set; }

        [Range(-273, 273, ErrorMessage = "Invalid temp")]
        public int TempC { get; set; }

        [Range(0, 2, ErrorMessage = "Invalid num")]
        public Helper.Output Output { get; set; }

        public int GetTempF()
        {
            TempF = ((TempC * 9) / 5) + 32;
            return TempF;
        }

    }
}
