using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserOrgManagementSystem.Data;
using UserOrgManagementSystem.Models;

namespace UserOrgManagementSystem.Controllers
{
    public class OrganisationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrganisationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var organisations = await _context.Organisations.ToListAsync();
            return View(organisations);
        }

        // Add Create, Edit, Details, Delete actions here.
        // Ensure each action includes necessary views and form handling.
    }
}