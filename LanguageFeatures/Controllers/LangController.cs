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

            decimal cartTotal = cart.TotalPrices();


            return View("Index", new string[] { $"Total: {cartTotal:C2}" });

        }
    }
}
