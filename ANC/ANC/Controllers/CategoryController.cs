using Microsoft.AspNetCore.Mvc;

namespace ANC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
