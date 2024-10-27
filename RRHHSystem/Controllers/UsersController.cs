using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RRHHSystem.Data;
using RRHHSystem.Models;
using System.Linq;

namespace RRHHSystem.Controllers
{
    [Authorize(Roles = "Admin")] // Solo el Admin puede acceder a esta sección
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Acción para mostrar el listado de usuarios y el formulario de actualización de roles
        public IActionResult ManageUsers()
        {
            var users = _context.Users.ToList();
            return View(users); // Pasa la lista de usuarios a la vista
        }

        // Acción para actualizar el rol del usuario
        [HttpPost]
        public IActionResult UpdateUserRole(int userId, string role)
        {
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                user.Role = role;
                _context.SaveChanges();
            }
            return RedirectToAction("ManageUsers");
        }
    }
}
