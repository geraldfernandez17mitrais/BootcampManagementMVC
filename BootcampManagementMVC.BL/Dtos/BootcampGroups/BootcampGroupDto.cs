using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.BL.Dtos.BootcampGroups
{
    public class BootcampGroupDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(45, ErrorMessage = "Name must be less than 45 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [StringLength(100, ErrorMessage = "Description must be less than 100 characters.")]
        public string Description { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Status is required.")]
        public bool IsActive { get; set; }

        public int SyllabusId { get; set; }
    }
}