using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }


        // HasOne Relationships
        public int Bootcamp_group_id { get; set; }
        [ForeignKey("Bootcamp_group_id")]
        public BootcampGroup BootcampGroup { get; set; }


        // Another fields
        public int User_id { get; set; }
        public int Manager_user_id { get; set; }
        public bool Is_approved { get; set; }
        public DateTime Confirm_date { get; set; }
        public string Message { get; set; }
    }
}
