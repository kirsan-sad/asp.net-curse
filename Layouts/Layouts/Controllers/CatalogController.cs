using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Layouts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Layouts.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            //var cat = new Repository();
            //ViewBag.Content = Repository.;

            return View();
        }

        public IActionResult Phones()
        {
            var phones = new Phones();
            ViewBag.Content = phones.GetContent();
            return View();
        }

        public IActionResult Cameras()
        {
            var camera = new Cameras();
            ViewBag.Content = camera.GetContent();
            return View();
        }

        public IActionResult Notebooks()
        {
            var notebook = new Notebooks();
            ViewBag.Content = notebook.GetContent();
            return View();
        }

        public IActionResult Headphoneses()
        {
            var headphones = new Headphoneses();
            ViewBag.Content = headphones.GetContent();
            return View();
        }
    }
}