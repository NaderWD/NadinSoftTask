using Microsoft.AspNetCore.Mvc;
using NadinSoftTask.Application.Interfaces;
using NadinSoftTask.Domain.Models;

namespace NadinSoftTask.Presentation.WebAPI.Controllers
{
    public class ProductController(IProductServices services) : Controller
    {
        private readonly IProductServices _services = services;

        public IActionResult Get(int id)
        {
            var result = _services.GetProductById(id);
            return View(result);
        }

        public IActionResult GetAll()
        {
            var result = _services.GetAllProducts();
            return View(result);
        }

        public IActionResult Insert()
        {
            var product = new Product()
            {
                Id = 0,
                Name = "Sib",
                ManufacturePhone = "09122065049",
                ManufactureEmail = "Nader.asadpour1993@gmail.com",
                IsAvailable = true
            };
            _services.AddProduct(product);
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var result = _services.GetProductById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _services.UpdateProduct(product);
            return View();
        }

        public IActionResult Delete(int id)
        {
            _services.DeleteProductById(id);
            return View();
        }
    }
}
