using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Domain.Models
{
    public class BootcampGroup : AuditAble
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(45, ErrorMessage = "Name must be less than 45 characters.")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Description must be less than 100 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public bool IsActive { get; set; }

        // Relationships
        public List<Request> Requests { get; set; }
        public List<UserBootcamp> UserBootcamps { get; set; }

        // One to One Relationship
        public Syllabus Syllabus { get; set; }
    }
}