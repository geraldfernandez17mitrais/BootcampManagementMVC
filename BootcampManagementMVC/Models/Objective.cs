using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class Objective : AuditAbleEntity
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int SyllabusId { get; set; }

        [ForeignKey(nameof(SyllabusId))]
        public Syllabus Syllabus { get; set; }

        public int BeltId { get; set; }

        [ForeignKey(nameof(BeltId))]
        public Belt Belt { get; set; }

        // Another fields
        [Range(1, 100, ErrorMessage = "Please enter a value between 1 and 100.")]
        public int SortNo { get; set; }

        [StringLength(100, ErrorMessage = "Name must be less than 100 characters.")]
        public string Name { get; set; }

        // Relationships
        public List<ObjectiveItem> ObjectiveItems { get; set; }
    }
}