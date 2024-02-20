using Microsoft.AspNetCore.Mvc;

namespace DoTerraWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
