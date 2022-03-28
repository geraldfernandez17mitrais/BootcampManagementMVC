using BootcampManagementMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BootcampManagementMVC.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Belt> belts { get; set; }
        public DbSet<BootcampGroup> bootcamp_groups { get; set; }
        public DbSet<Objective> objectives { get; set; }
        public DbSet<ObjectiveItem> objective_items { get; set; }
        public DbSet<ObjectiveItemStatusLearning> objective_items_status_learnings { get; set; }
        public DbSet<Request> requests { get; set; }
        public DbSet<StatusLearning> status_learnings { get; set; }
        public DbSet<Syllabus> syllabuses { get; set; }
        public DbSet<UserBootcamp> user_bootcamps { get; set; }

        // dummy:
        public DbSet<BootcampMember> bootcamp_members { get; set; }
    }
}
