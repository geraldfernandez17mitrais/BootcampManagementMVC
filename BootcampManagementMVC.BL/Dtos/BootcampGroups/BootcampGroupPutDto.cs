using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.BL.Dtos.BootcampGroups
{
    public class BootcampGroupPutDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}