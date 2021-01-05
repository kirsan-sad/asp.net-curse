using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Layouts.Views;
using Microsoft.AspNetCore.Mvc;

namespace Layouts.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            var cat = new Catalog();
            ViewBag.Content = cat.GetContent("Camera");

            return View();
        }

        public IActionResult Phones()
        {
            var phones = new Catalog();
            ViewBag.Content = phones.GetContent("Mobile_Phone");
            return View();
        }

        public IActionResult Cameras()
        {
            var camera = new Catalog();
            ViewBag.Content = camera.GetContent("Camera");
            return View();
        }

        public IActionResult Notebooks()
        {
            var notebook = new Catalog();
            ViewBag.Content = notebook.GetContent("Notebook");
            return View();
        }

        public IActionResult Headphoneses()
        {
            var headphones = new Catalog();
            ViewBag.Content = headphones.GetContent("Headphones");
            return View();
        }
    }
}