using DiscogsTestPetal.DataAccess;
using DiscogsTestPetal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DiscogsTestPetal.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger, IDiscCollectionData discCollectionData)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitSearch(SearchParameters param)
        {
            return Redirect("/Collection/GetCollection/" + param.Quantity.ToString());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }    
    }
}
