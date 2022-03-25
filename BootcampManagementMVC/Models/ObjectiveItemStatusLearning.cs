using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Models
{
    public class ObjectiveItemStatusLearning
    {
        [Key]
        public int Id { get; set; }


        // HasOne Relationships
        public int Objective_item_id { get; set; }
        [ForeignKey("Objective_item_id")]
        public ObjectiveItem ObjectiveItem { get; set; }

        public int Status_learning_id { get; set; }
        [ForeignKey("Status_learning_id")]
        public StatusLearning StatusLearning { get; set; }


        // Another fields
        public int User_id { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string Comment { get; set; }
    }
}
