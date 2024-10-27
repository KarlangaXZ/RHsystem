using Microsoft.AspNetCore.Mvc;

namespace RRHHSystem.Controllers
{
    public class AdminController : Controller
    {
        // Acción que devuelve la vista del Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
