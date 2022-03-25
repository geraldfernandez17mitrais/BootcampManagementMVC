using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class UserBootcamp
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int Bootcamp_group_id { get; set; }
        [ForeignKey("Bootcamp_group_id")]
        public BootcampGroup BootcampGroup { get; set; }

        // Another field
        public int User_id { get; set; }
        public bool Is_active { get; set; }
        public DateTime Join_date { get; set; }
        public DateTime End_date { get; set; }
    }
}
