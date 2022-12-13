using Microsoft.AspNetCore.Mvc;

namespace SinavSistemi.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
