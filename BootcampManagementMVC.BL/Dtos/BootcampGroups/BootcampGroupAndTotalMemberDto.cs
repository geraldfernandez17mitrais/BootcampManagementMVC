using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.BL.Dtos.BootcampGroups
{
    public class BootcampGroupAndTotalMemberDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        [Display(Name = "Current Members")]
        public int CountMember { get; set; }

        public int SyllabusId { get; set; }
    }
}