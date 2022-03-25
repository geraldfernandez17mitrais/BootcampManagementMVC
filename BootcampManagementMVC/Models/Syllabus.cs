using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class Syllabus
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int Bootcamp_group_id { get; set; }
        [ForeignKey("Bootcamp_group_id")]
        public BootcampGroup BootcampGroup { get; set; }

        // Another field
        public string Name { get; set; }

        // Relationships
        public List<Objective> Objectives { get; set; }
    }
}
