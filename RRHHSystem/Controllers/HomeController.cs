using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RegistrarUsuario(string username, string password)
    {
        // Lógica para registrar al usuario
        return RedirectToAction("Index");
    }
}
