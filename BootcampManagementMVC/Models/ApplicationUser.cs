using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full name")]
        [StringLength(45, ErrorMessage = "Full Name must be less than 45 characters.")]
        public string FullName { get; set; }
    }
}