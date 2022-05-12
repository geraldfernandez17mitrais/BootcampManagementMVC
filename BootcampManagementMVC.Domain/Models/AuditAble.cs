using System;
using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Domain.Models
{
    public class AuditAble
    {
        public DateTime CreatedDate { get; set; }

        [StringLength(15, ErrorMessage = "CreatedBy must be less than 15 characters.")]
        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        [StringLength(15, ErrorMessage = "ModifiedBy must be less than 15 characters.")]
        public string ModifiedBy { get; set; }
    }
}