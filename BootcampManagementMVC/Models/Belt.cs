using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Models
{
    public class Belt
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Belt Name")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Display(Name = "Color Name")]
        [Required(ErrorMessage = "Color is required.")]
        public string Color { get; set; }

        // Relationships
        public List<Objective> Objectives { get; set; }
    }
}
