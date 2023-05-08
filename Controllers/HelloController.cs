using Microsoft.AspNetCore.Mvc;
using MS_Prac.Models;

namespace MS_Prac.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View("");


        }

        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Jayesh Gupta",
                Gender = "Male"
            };


        return View(student);

        }

    }

}
