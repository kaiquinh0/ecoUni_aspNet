using Microsoft.AspNetCore.Mvc;

namespace ecoUni.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}
