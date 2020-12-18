using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter
{
   public interface IValidator
    {
        public IActionResult GetTempFile(int tempC, Helper.Output output);

        public int GetTempFahrenheit(int tempC);
    }
}
