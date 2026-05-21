using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
//using WUF2.Models;

namespace WUF2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
