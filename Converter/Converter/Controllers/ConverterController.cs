using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Converter.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class ConverterController : ControllerBase
    {
        public int TempF { get; set; }

        [HttpGet]
        [Route("Convert")]
        public IActionResult Convert(ValidationTemp valid)
        {
            if (ModelState.IsValid)
            {
                var res = valid.GetTempF();
                return Content($"Температура в Фарингейтах равна: {res}");
            }
            else
            {
                return StatusCode(400);
            }
        }
    }
}