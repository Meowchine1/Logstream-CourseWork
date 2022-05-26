using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Norilsk.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Norilsk.Controllers
{
    public class ResoursesController : Controller
    {
      
        public IActionResult Index(int id)
        {
            return View();
        }

        public IActionResult Show(int id)
        {
            return Content("Publications" + id);
        }

      
    }
}
