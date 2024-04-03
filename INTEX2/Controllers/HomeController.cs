//using INTEX2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace INTEX2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
