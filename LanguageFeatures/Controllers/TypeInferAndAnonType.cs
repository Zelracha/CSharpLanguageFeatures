using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class TypeInferAndAnonType : Controller
    {
        public ViewResult Index()
        {
            // using anonymous types and type inference
            IProductSelection cart = new ShoppingCart(
                new Product { Name = "Kayak", Price = 275M},
                new Product { Name = "Life Jacket", Price = 48.95M },
                new Product { Name = "Baseball Ball", Price = 19.50M },
                new Product { Name = "Country Flag", Price = 34.95M }
                );
            return View(cart.Names);
        }
    }
}
