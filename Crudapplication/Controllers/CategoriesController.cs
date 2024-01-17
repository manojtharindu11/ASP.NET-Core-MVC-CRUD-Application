using Microsoft.AspNetCore.Mvc;
using Crudapplication.Models;

namespace Crudapplication.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            var category = new Category { categoryId = id.HasValue?id.Value:0 };

            return View(category);
        }
    }
}
