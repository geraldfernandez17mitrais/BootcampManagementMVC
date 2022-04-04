using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class ObjectiveItemStatusLearning : AuditAbleEntity
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int ObjectiveItemId { get; set; }

        [ForeignKey(nameof(ObjectiveItemId))]
        public ObjectiveItem ObjectiveItem { get; set; }

        public int StatusLearningId { get; set; }

        [ForeignKey(nameof(StatusLearningId))]
        public StatusLearning StatusLearning { get; set; }

        // Another fields
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [StringLength(100, ErrorMessage = "Comment must be less than 100 characters.")]
        public string Comment { get; set; }
    }
}