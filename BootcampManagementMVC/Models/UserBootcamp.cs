using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class UserBootcamp : AuditAbleEntity
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int BootcampGroupId { get; set; }

        [ForeignKey(nameof(BootcampGroupId))]
        public BootcampGroup BootcampGroup { get; set; }

        // Another field
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}