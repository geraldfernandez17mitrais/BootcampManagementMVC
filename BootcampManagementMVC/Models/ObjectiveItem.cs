using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class ObjectiveItem
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int Objective_id { get; set; }
        [ForeignKey("Objective_id")]
        public Objective Objective { get; set; }


        // Another fields
        public int Sort_no { get; set; }
        public string Name { get; set; }
        public string Goal { get; set; }
        public string Reference { get; set; }
        public int Estimation_time { get; set; }

        // Relationships
        public List<ObjectiveItemStatusLearning> ObjectiveItemsStatusLearnings { get; set; }
    }
}
