using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class Objective
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int Syllabus_id { get; set; }
        [ForeignKey("Syllabus_id")]
        public Syllabus Syllabus { get; set; }

        public int Belt_id { get; set; }
        [ForeignKey("Belt_id")]
        public Belt Belt { get; set; }


        // Another fields
        public int Sort_no { get; set; }
        public string Name { get; set; }

        // Relationships
        public List<ObjectiveItem> ObjectiveItems { get; set; }
    }
}
