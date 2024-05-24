using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class LambdaExpressionMethods : Controller
    {
        public IActionResult Index() => View(Product.GetProducts().Select(p => p?.Name));
       
    }
}
