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

           /* bool FilterByPrice(Product? p)
            {
                return (p?.Price ?? 0) >= 20;
            }*/

           ShoppingCart cart = new ShoppingCart 
           {
               products = Product.GetProducts()
           };

            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Baseball Ball", Price = 19.50M },
                new Product {Name = "Country Flag", Price = 34.95M}
            };

           /* Func<Product?, bool> nameFilter = delegate (Product? prod)
            {
                return prod?.Name[0] == 'B';
            };*/
           
            // Using Lambda expression
            decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
            decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'B').TotalPrices();

            return View("Index", new string[] { $"Price Total: {priceFilterTotal:C2}", $"Name Total: {nameFilterTotal:C2}" });

        }
    }
}
