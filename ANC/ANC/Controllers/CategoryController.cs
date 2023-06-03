using ANC.Data;
using Microsoft.AspNetCore.Mvc;

namespace ANC.Controllers
{
    public class CategoryController : Controller
    {
        //create db
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
