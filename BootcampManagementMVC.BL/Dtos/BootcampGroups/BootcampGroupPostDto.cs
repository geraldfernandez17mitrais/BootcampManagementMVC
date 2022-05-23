using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.BL.Dtos.BootcampGroups
{
    public class BootcampGroupPostDto
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public bool IsActive { get; set; }
    }
}