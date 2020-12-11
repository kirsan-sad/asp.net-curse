using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Converter.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class ConverterController : Controller
    {
        public int TempF { get; set; }

        [HttpGet]
        [Route("Convert")]
        public IActionResult Convert(ValidationTemp valid)
        {
            if (ModelState.IsValid)
            {
                var downloadResult = valid.GetTempF();
                return downloadResult;
            }
            else
            {
                return StatusCode(400);
            }
        }

    }
}