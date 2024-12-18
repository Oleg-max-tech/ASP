using System.Web.Mvc;
using ASP1.Models;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ASP1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult ProductsList()
        {
            // Створення тестового продукту
            Product product = new Product
            {
                Name = "Смартфон",
                Price = 15000.50m,
                Description = "Смартфон з великим екраном та потужним акумулятором",
                ManufactureDate = new DateTime(2024, 10, 15)
            };

            // Передача даних у View
            ViewBag.Description = product.Description;
            ViewData["ManufactureDate"] = product.ManufactureDate.ToString("yyyy-MM-dd");

            return View(product);
        }
    }
}
