using Microsoft.AspNetCore.Mvc;

namespace AspNetEFCodeCrud.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
