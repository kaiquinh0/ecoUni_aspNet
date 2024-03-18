// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        // Lógica de autenticação (fictícia)
        if (username == "admin" && password == "password")
        {
            // Autenticação bem-sucedida
            return RedirectToAction("Index", "Home");
        }
        else
        {
            // Autenticação falhou
            ViewBag.ErrorMessage = "Credenciais inválidas. Por favor, tente novamente.";
            return View("Index");
        }
    }
}
