using System.ComponentModel.DataAnnotations;

namespace UserOrgManagementSystem.Models
{
    public class Organisation
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        public ICollection<User> Users { get; set; }
    }
}