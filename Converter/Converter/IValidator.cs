using Converter.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter
{
   public interface IValidator
    {
        public IActionResult GetTempFile(int tempC, FileType fileType);

        public int GetTempFahrenheit(int tempC);
    }
}
