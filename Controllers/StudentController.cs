using Microsoft.AspNetCore.Mvc;
using Stavnic_Adrian_Lab1.Models;

namespace Stavnic_Adrian_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now;
            var student = new Student
            {
                Name = "Adrian",
                Age = 23
            };
            return View(student);
        }
    }
}
