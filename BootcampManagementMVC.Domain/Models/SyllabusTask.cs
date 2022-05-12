using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Domain.Models
{
    public class SyllabusTask : AuditAble
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int SyllabusId { get; set; }

        [ForeignKey(nameof(SyllabusId))]
        public Syllabus Syllabus { get; set; }

        public int StageId { get; set; }

        [ForeignKey(nameof(StageId))]
        public Stage Stage { get; set; }

        // Another fields
        [StringLength(100, ErrorMessage = "Title must be less than 100 characters.")]
        public string Title { get; set; }

        [StringLength(200, ErrorMessage = "Description must be less than 200 characters.")]
        public string Description { get; set; }

        public string Reference { get; set; }
        public int DurationEstimate { get; set; }
    }
}