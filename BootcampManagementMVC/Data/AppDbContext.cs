using BootcampManagementMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BootcampManagementMVC.Data
{
    // Change DbContext to IdentityDbContext to use Identity Framework. Many tables for authentication purpose will be generated automaticaly when updating the database after creating new migration file.
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

        // mapping properties and fields name:
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Belt:
            builder.Entity<Belt>()
                .Property(b => b.CreatedDate).HasColumnName("created_date");

            builder.Entity<Belt>()
                .Property(b => b.CreatedBy).HasColumnName("created_by");

            builder.Entity<Belt>()
                .Property(b => b.ModifiedDate).HasColumnName("modified_date");

            builder.Entity<Belt>()
                .Property(b => b.ModifiedBy).HasColumnName("modified_by");

            // BootcampGroup:
            builder.Entity<BootcampGroup>()
                .Property(b => b.IsActive).HasColumnName("is_active");

            builder.Entity<BootcampGroup>()
                .Property(b => b.CreatedDate).HasColumnName("created_date");

            builder.Entity<BootcampGroup>()
                .Property(b => b.CreatedBy).HasColumnName("created_by");

            builder.Entity<BootcampGroup>()
                .Property(b => b.ModifiedDate).HasColumnName("modified_date");

            builder.Entity<BootcampGroup>()
                .Property(b => b.ModifiedBy).HasColumnName("modified_by");

            // Objective:
            builder.Entity<Objective>()
                .Property(b => b.SyllabusId).HasColumnName("syllabus_id");

            builder.Entity<Objective>()
                .Property(b => b.BeltId).HasColumnName("belt_id");

            builder.Entity<Objective>()
                .Property(b => b.SortNo).HasColumnName("sort_no");

            builder.Entity<Objective>()
                .Property(b => b.CreatedDate).HasColumnName("created_date");

            builder.Entity<Objective>()
                .Property(b => b.CreatedBy).HasColumnName("created_by");

            builder.Entity<Objective>()
                .Property(b => b.ModifiedDate).HasColumnName("modified_date");

            builder.Entity<Objective>()
                .Property(b => b.ModifiedBy).HasColumnName("modified_by");

            // ObjectiveItem:
            builder.Entity<ObjectiveItem>()
                .Property(b => b.ObjectiveId).HasColumnName("objective_id");

            builder.Entity<ObjectiveItem>()
                .Property(b => b.SortNo).HasColumnName("sort_no");

            builder.Entity<ObjectiveItem>()
                .Property(b => b.EstimationMinuteTime).HasColumnName("estimation_minute_time");

            builder.Entity<ObjectiveItem>()
                .Property(b => b.CreatedDate).HasColumnName("created_date");

            builder.Entity<ObjectiveItem>()
                .Property(b => b.CreatedBy).HasColumnName("created_by");

            builder.Entity<ObjectiveItem>()
                .Property(b => b.ModifiedDate).HasColumnName("modified_date");

            builder.Entity<ObjectiveItem>()
                .Property(b => b.ModifiedBy).HasColumnName("modified_by");

            // ObjectiveItemStatusLearning:
            builder.Entity<ObjectiveItemStatusLearning>()
                .Property(b => b.ObjectiveItemId).HasColumnName("objective_item_id");

            builder.Entity<ObjectiveItemStatusLearning>()
                .Property(b => b.StatusLearningId).HasColumnName("status_learning_id");

            builder.Entity<ObjectiveItemStatusLearning>()
                .Property(b => b.UserId).HasColumnName("user_id");

            builder.Entity<ObjectiveItemStatusLearning>()
                .Property(b => b.StartDate).HasColumnName("start_date");

            builder.Entity<ObjectiveItemStatusLearning>()
                .Property(b => b.EndDate).HasColumnName("end_date");

            builder.Entity<ObjectiveItemStatusLearning>()
                .Property(b => b.CreatedDate).HasColumnName("created_date");

            builder.Entity<ObjectiveItemStatusLearning>()
                .Property(b => b.CreatedBy).HasColumnName("created_by");

            builder.Entity<ObjectiveItemStatusLearning>()
                .Property(b => b.ModifiedDate).HasColumnName("modified_date");

            builder.Entity<ObjectiveItemStatusLearning>()
                .Property(b => b.ModifiedBy).HasColumnName("modified_by");

            // Request:
            builder.Entity<Request>()
                .Property(b => b.BootcampGroupId).HasColumnName("bootcamp_group_id");

            builder.Entity<Request>()
                .Property(b => b.UserId).HasColumnName("user_id");

            builder.Entity<Request>()
                .Property(b => b.ManagerUserId).HasColumnName("manager_user_id");

            builder.Entity<Request>()
                .Property(b => b.IsApproved).HasColumnName("is_approved");

            builder.Entity<Request>()
                .Property(b => b.ConfirmDate).HasColumnName("confirm_date");

            builder.Entity<Request>()
                .Property(b => b.CreatedDate).HasColumnName("created_date");

            builder.Entity<Request>()
                .Property(b => b.CreatedBy).HasColumnName("created_by");

            builder.Entity<Request>()
                .Property(b => b.ModifiedDate).HasColumnName("modified_date");

            builder.Entity<Request>()
                .Property(b => b.ModifiedBy).HasColumnName("modified_by");

            // StatusLearning:
            builder.Entity<StatusLearning>()
                .Property(b => b.CreatedDate).HasColumnName("created_date");

            builder.Entity<StatusLearning>()
                .Property(b => b.CreatedBy).HasColumnName("created_by");

            builder.Entity<StatusLearning>()
                .Property(b => b.ModifiedDate).HasColumnName("modified_date");

            builder.Entity<StatusLearning>()
                .Property(b => b.ModifiedBy).HasColumnName("modified_by");

            // Syllabus:
            builder.Entity<Syllabus>()
                .Property(b => b.BootcampGroupId).HasColumnName("bootcamp_group_id");

            // UserBootcamp:
            builder.Entity<UserBootcamp>()
                .Property(b => b.BootcampGroupId).HasColumnName("bootcamp_group_id");

            builder.Entity<UserBootcamp>()
                .Property(b => b.UserId).HasColumnName("user_id");

            builder.Entity<UserBootcamp>()
                .Property(b => b.IsActive).HasColumnName("is_active");

            builder.Entity<UserBootcamp>()
                .Property(b => b.JoinDate).HasColumnName("join_date");

            builder.Entity<UserBootcamp>()
                .Property(b => b.EndDate).HasColumnName("end_date");

            builder.Entity<UserBootcamp>()
                .Property(b => b.CreatedDate).HasColumnName("created_date");

            builder.Entity<UserBootcamp>()
                .Property(b => b.CreatedBy).HasColumnName("created_by");

            builder.Entity<UserBootcamp>()
                .Property(b => b.ModifiedDate).HasColumnName("modified_date");

            builder.Entity<UserBootcamp>()
                .Property(b => b.ModifiedBy).HasColumnName("modified_by");

            // BootcampMember
            builder.Entity<BootcampMember>()
                .Property(b => b.FullName).HasColumnName("full_name");

            builder.Entity<BootcampMember>()
                .Property(b => b.CreatedDate).HasColumnName("created_date");

            builder.Entity<BootcampMember>()
                .Property(b => b.CreatedBy).HasColumnName("created_by");

            builder.Entity<BootcampMember>()
                .Property(b => b.ModifiedDate).HasColumnName("modified_date");

            builder.Entity<BootcampMember>()
                .Property(b => b.ModifiedBy).HasColumnName("modified_by");

            base.OnModelCreating(builder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            UserManager<ApplicationUser> _userManager;

            // Get all the entities that inherit from AuditAbleEntity and have a state of Added or Modified
            var entries = ChangeTracker
                    .Entries()
                    .Where(e => e.Entity is AuditAbleEntity && (
                            e.State == EntityState.Added
                            || e.State == EntityState.Modified));

            // For each entity we will set the Audit properties
            foreach (var entityEntry in entries)
            {
                // If the entity state is Added let's set the Created_date and Created_by properties
                if (entityEntry.State == EntityState.Added)
                {
                    ((AuditAbleEntity)entityEntry.Entity).CreatedDate = DateTime.UtcNow;
                    ((AuditAbleEntity)entityEntry.Entity).CreatedBy = "";
                }
                else
                {
                    // If the state is Modified then we don't want to modify the Created_date and Created_by properties so we set their state as IsModified to false
                    Entry((AuditAbleEntity)entityEntry.Entity).Property(p => p.CreatedDate).IsModified = false;
                    Entry((AuditAbleEntity)entityEntry.Entity).Property(p => p.CreatedBy).IsModified = false;
                }

                // In any case we always want to set the properties Modified_date and Modified_by
                ((AuditAbleEntity)entityEntry.Entity).ModifiedDate = DateTime.UtcNow;
                ((AuditAbleEntity)entityEntry.Entity).ModifiedBy = "";
            }

            // After we set all the needed properties we call the base implementation of SaveChangesAsync to actually save our entities in the database
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}