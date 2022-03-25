using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Models
{
    public class BootcampGroup
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Bootcamp Name")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Display(Name = "Bootcamp Description")]
        public string Description { get; set; }

        [Display(Name = "Bootcamp Status")]
        [Required(ErrorMessage = "Bootcamp Status is required.")]
        public bool Is_active { get; set; }

        // Relationships
        public List<Request> Requests { get; set; }
        public List<UserBootcamp> UserBootcamps { get; set; }
        public List<Syllabus> Syllabuses { get; set; }
    }
}
