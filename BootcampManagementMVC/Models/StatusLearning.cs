using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Models
{
    public class StatusLearning : AuditAbleEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(15, ErrorMessage = "Name must be less than 15 characters.")]
        public string Name { get; set; }

        // Relationships
        public List<ObjectiveItemStatusLearning> ObjectiveItemsStatusLearnings { get; set; }
    }
}