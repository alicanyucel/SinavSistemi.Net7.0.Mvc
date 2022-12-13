using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SinavSistemi.DataContex;
using SinavSistemi.Models;

namespace SinavSistemi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
