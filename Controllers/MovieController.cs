using Microsoft.AspNetCore.Mvc;
namespace MovieApp.Controllers
{
    public class MovieController:Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Detail()
        {
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            return View();
        }                
    }
}