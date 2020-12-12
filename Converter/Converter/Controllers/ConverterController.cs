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

        [HttpGet]
        [Route("Convert")]
        public IActionResult Convert(ValidationTemp valid)
        {
            if (ModelState.IsValid)
            {
                return valid.GetTempF();
            }
            else
            {
                return StatusCode(400);
            }
        }

    }
}