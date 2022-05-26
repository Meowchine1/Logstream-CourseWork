using Microsoft.AspNetCore.Mvc;
using norilskyNikel1.Models;
using System.Diagnostics;

namespace norilskyNikel1.Controllers
{
    public class ResoursesController : Controller
    {

        public IActionResult Index()
        {
           return Content("Hello");
        }

    }
}