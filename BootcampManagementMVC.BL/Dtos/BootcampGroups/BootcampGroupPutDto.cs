using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.BL.Dtos.BootcampGroups
{
    public class BootcampGroupPutDto
    {
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number is allowed.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [Display(Name = "Status")]
        public bool IsActive { get; set; }
    }
}