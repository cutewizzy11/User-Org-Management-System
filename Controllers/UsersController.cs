using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserOrgManagementSystem.Data;
using UserOrgManagementSystem.Models;


namespace UserOrgManagementSystem.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.Include(u => u.Organisation).ToListAsync();
            return View(users);
        }

        // Add Create, Edit, Details, Delete actions here.
        // Ensure each action includes necessary views and form handling.
    }
}
