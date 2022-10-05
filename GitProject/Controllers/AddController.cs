using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProject.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Index()
        {
            int a = 5, b = 10;
            int c = a + b;
            ViewBag.c = c;
            return View();
        } public IActionResult Subtraction()
        {
            int a = 10, b = 5;
            int c = a - b;
            ViewBag.c = c;
            return View();
        }

    }
}
