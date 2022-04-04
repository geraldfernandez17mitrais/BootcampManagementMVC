using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Models
{
    public class Belt : AuditAbleEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Belt Name")]
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(15, ErrorMessage = "Name must be less than 15 characters.")]
        public string Name { get; set; }

        [Display(Name = "Color Name")]
        [Required(ErrorMessage = "Color is required.")]
        public string Color { get; set; }

        // Relationships
        public List<Objective> Objectives { get; set; }
    }
}