using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RRHHSystem.Data;
using RRHHSystem.Models;
using System.Linq;

namespace RRHHSystem.Controllers
{
    [Authorize(Roles = "Admin")] 
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult ManageUsers()
        {
            var users = _context.Users.ToList();
            return View(users); 
        }

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
