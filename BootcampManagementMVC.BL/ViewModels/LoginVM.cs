﻿using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.BL.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required.")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
