using Microsoft.AspNetCore.Mvc;

namespace CourseWebProject.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
