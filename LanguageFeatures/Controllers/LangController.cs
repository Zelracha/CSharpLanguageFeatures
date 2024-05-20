using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;
namespace LanguageFeatures.Controllers
{
    public class LangController : Controller
    {
        public IActionResult Index()
        {
            /*   Product?[] products = Product.GetProducts();
               return View(new string[] {
               $"Name: {products[0]?.Name}, Price: { products[0]?.Price }"
               });*/

           ShoppingCart cart = new ShoppingCart 
           {
               products = Product.GetProducts()
           };

            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M}
            };

            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.TotalPrices();

            return View("Index", new string[] { $" Cart Total: {cartTotal:C2}", $"Array Total: {arrayTotal:C2}" });

        }
    }
}
