using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using RRHHSystem.Data;
using RRHHSystem.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RRHHSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            // Buscar al usuario en la base de datos
            var user = _context.Users.FirstOrDefault(u => u.Username == Username);

            if (user != null && VerifyPassword(Password, user.PasswordHash))
            {
                if (user.Role == "Admin")
                {
                    TempData["Success"] = "Login exitoso, bienvenido al Dashboard del Admin.";
                    return RedirectToAction("Dashboard", "Admin");
                }

                TempData["Success"] = "Login exitoso, bienvenido.";
                return RedirectToAction("Index", "Home");
            }

            // Si el login falla
            TempData["Error"] = "Usuario o contraseña incorrectos.";
            return RedirectToAction("Index");
        }


        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            var passwordHasher = new PasswordHasher<string>();
            return passwordHasher.VerifyHashedPassword(null, storedHash, enteredPassword) == PasswordVerificationResult.Success;
        }

        [HttpPost]
        public IActionResult Register(User newUser)
        {

            newUser.PasswordHash = HashPassword(newUser.PasswordHash);
            _context.Users.Add(newUser);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}