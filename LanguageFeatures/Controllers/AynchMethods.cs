using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace LanguageFeatures.Controllers
{
    public class AynchMethods : Controller
    {
        public async Task<IActionResult> Index()
        {
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Page Length: {length}" });
        }
    }
}
