using BootcampManagementMVC.Domain.Models;
using System;

namespace BootcampManagementMVC.BL.Dtos.UserBootcamps
{
    public class UserBootcampDto
    {
        public int Id { get; set; }
        public int BootcampGroupId { get; set; }
        public BootcampGroup BootcampGroup { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}