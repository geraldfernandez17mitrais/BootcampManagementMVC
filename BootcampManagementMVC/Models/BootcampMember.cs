using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Models
{
    public class BootcampMember : AuditAbleEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Member Full Name")]
        [Required(ErrorMessage = "FullName is required.")]
        [StringLength(45, ErrorMessage = "FullName must be less than 45 characters.")]
        public string FullName { get; set; }
    }
}