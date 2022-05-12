using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Domain.Models
{
    public class Stage : AuditAble
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(15, ErrorMessage = "Name must be less than 15 characters.")]
        public string Name { get; set; }
        public int Sort { get; set; }
        // Relationships
        public List<SyllabusTask> SyllabusTasks { get; set; }
    }
}