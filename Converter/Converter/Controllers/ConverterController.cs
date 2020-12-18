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
    [Route("[controller]")]
    public class ConverterController : Controller
    {
        private IValidator _validator;

        public ConverterController(IValidator validator)
        {
            _validator = validator;
        }

        [HttpGet]
        [Route("Convert")]
        public IActionResult Convert(ValidationTemp valid)
        {
            if (ModelState.IsValid)
            {
                return _validator.GetTempFile(valid.TempC, valid.Output);
            }
            else
            {
                return StatusCode(400);
            }
        }

        [Route("Redirect")]
        public IActionResult Redirect()
        {
            return Redirect("https://www.it-academy.by/");
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return View(new ValidationTemp());
        }

        [HttpPost]
        [Route("Index")]
        public IActionResult Index(ValidationTemp valid)
        {
            int TempF = 0;

            if (ModelState.IsValid)
            {
                TempF = _validator.GetTempFahrenheit(valid.TempC);
            }
            else
            {
                return BadRequest();
            }

            ViewData["TempF"] = TempF;

            return View(valid);
        }
    }
}