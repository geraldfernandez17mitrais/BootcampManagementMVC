using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Domain.Models
{
    public class BootcampMember : AuditAble
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}