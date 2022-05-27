using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorilskNikel.EF;
using NorilskNikel.Models;
using System.Diagnostics;

namespace NorilskNikel.Controllers
{
    public class NornikelController : Controller
    {
       

        public IActionResult Index(int id)
        {
            NornikelContext db = new NornikelContext();
            ViewBag.Categories = db.categories.ToList();
        

            if (id == 0)
            {
                ViewBag.Resourses = db.resourses.ToList();
            }
            else
            {
                ViewBag.Resourses = db.resourses.Where(x => x.CategoryId == id).ToList();

            }

            return View();
        }

        public IActionResult Resourse(string id) {

            NornikelContext db = new NornikelContext();
            Resourses r = db.resourses.FirstOrDefault(x => x.path == id);
            if (r == null)
            {
                return NotFound();
            }

            ViewBag.Categories = db.categories.ToList();
            ViewBag.Resourse = r;

            return View();
           
        }   
        public IActionResult CategoryResourses(int id) {

            NornikelContext db = new NornikelContext();
            Categories category = db.categories.FirstOrDefault(x => x.Id == id); 
 
            if (category == null)
            {
                return NotFound();
            }

            ViewBag.Category = category;
            ViewBag.Categories = db.categories.ToList();
            ViewBag.Resourses = db.resourses.Where(x => x.CategoryId == id);

            return View();
           
        }  
        public IActionResult BuyProduct(int id) {

           

            return View();
           
        }
        [HttpPost]
        public IActionResult Search(string request) {

            if (request == null)
            {
                NornikelContext db = new NornikelContext();
                ViewBag.flag = false;
                ViewBag.Categories = db.categories.ToList();
            }
            else
            {
                NornikelContext db = new NornikelContext();

                var result = db.resourses.Where(x => x.name.ToLower().Contains(request.ToLower())).ToList();

                ViewBag.result = result;
                ViewBag.flag = (result.Count() != 0)? true : false ;
                ViewBag.Categories = db.categories.ToList();
            }

            return View();
           
        }
      
    }
}