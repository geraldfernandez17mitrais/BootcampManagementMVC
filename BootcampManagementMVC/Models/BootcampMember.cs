using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Models
{
    public class BootcampMember
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Member Full Name")]
        [Required(ErrorMessage = "Full Name is required.")]
        public string Full_name { get; set; }
    }
}
