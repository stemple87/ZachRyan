using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZachRyan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Video()
        {
            ViewData["Message"] = "Your application Video page.";

            return View();
        }

        public IActionResult Stream()
        {
            ViewData["Message"] = "Your Stream page.";

            return View();
        }

        public IActionResult News()
        {
            ViewData["Message"] = "Your News page.";

            return View();
        }

        public IActionResult Tour()
        {
            ViewData["Message"] = "Your Tour page.";

            return View();
        }

        public IActionResult Sign_Up()
        {
            ViewData["Message"] = "Your Sign Up page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
