using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewAction()
        {
            return View();
        }

    }
}
