using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampManagementMVC.Models
{
    public class StatusLearning
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationships
        public List<ObjectiveItemStatusLearning> ObjectiveItemsStatusLearnings { get; set; }
    }
}
