using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class Request : AuditAbleEntity
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int BootcampGroupId { get; set; }

        [ForeignKey(nameof(BootcampGroupId))]
        public BootcampGroup BootcampGroup { get; set; }

        // Another fields
        public int UserId { get; set; }
        public int ManagerUserId { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ConfirmDate { get; set; }
        public string Message { get; set; }
    }
}