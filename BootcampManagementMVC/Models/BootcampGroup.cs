using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Models
{
    public class BootcampGroup : AuditAbleEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Bootcamp Name")]
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(45, ErrorMessage = "Name must be less than 45 characters.")]
        public string Name { get; set; }

        [Display(Name = "Bootcamp Description")]
        [StringLength(100, ErrorMessage = "Description must be less than 100 characters.")]
        public string Description { get; set; }

        [Display(Name = "Bootcamp Status")]
        [Required(ErrorMessage = "Status is required.")]
        public bool IsActive { get; set; }

        // Relationships
        public List<Request> Requests { get; set; }
        public List<UserBootcamp> UserBootcamps { get; set; }
        public List<Syllabus> Syllabuses { get; set; }
    }
}