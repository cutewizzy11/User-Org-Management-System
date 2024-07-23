using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace UserOrgManagementSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public ICollection<Organization> Organizations { get; set; } = new List<Organization>();
    }
}
