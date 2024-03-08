using DoTerra.DataAccess.Repository.IRepository;
using DoTerra.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoTerraWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Product> productsList = _unitOfWork.Product.GetAll().ToList();
            return View(productsList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if(obj.COD == 0)
            {
                ModelState.AddModelError("COD", "O código não pode ser 0");
            }

            if(ModelState.IsValid)
            {
                _unitOfWork.Product.Add(obj);
                _unitOfWork.Save();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
