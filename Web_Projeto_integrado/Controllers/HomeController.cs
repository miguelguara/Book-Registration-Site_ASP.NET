using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Projeto_integrado.Models;

namespace Web_Projeto_integrado.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
