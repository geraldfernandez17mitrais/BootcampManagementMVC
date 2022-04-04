using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class ObjectiveItem : AuditAbleEntity
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int ObjectiveId { get; set; }

        [ForeignKey(nameof(ObjectiveId))]
        public Objective Objective { get; set; }

        // Another fields
        [Range(1, 100, ErrorMessage = "Please enter a value between 1 and 100.")]
        public int SortNo { get; set; }

        [StringLength(100, ErrorMessage = "Name must be less than 100 characters.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Goal must be less than 200 characters.")]
        public string Goal { get; set; }

        public string Reference { get; set; }

        [Range(1, 10000, ErrorMessage = "Please enter a value between 1 and 1000.")]
        public int EstimationMinuteTime { get; set; }

        // Relationships
        public List<ObjectiveItemStatusLearning> ObjectiveItemsStatusLearnings { get; set; }
    }
}