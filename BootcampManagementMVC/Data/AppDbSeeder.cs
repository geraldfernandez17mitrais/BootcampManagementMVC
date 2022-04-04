using BootcampManagementMVC.Data.Static;
using BootcampManagementMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampManagementMVC.Data
{
    public class AppDbSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Status Learning
                if (!context.status_learnings.Any())
                {
                    context.status_learnings.AddRange(new List<StatusLearning>()
                    {
                        new StatusLearning()
                        {
                            Name = "Entry",
                            CreatedDate = DateTime.UtcNow
                        },
                        new StatusLearning()
                        {
                            Name = "On Progress",
                            CreatedDate = DateTime.UtcNow
                        },
                        new StatusLearning()
                        {
                            Name = "Finish",
                            CreatedDate = DateTime.UtcNow
                        }
                    });
                    context.SaveChanges();
                }

                // Belt
                if (!context.belts.Any())
                {
                    context.belts.AddRange(new List<Belt>()
                    {
                        new Belt()
                        {
                            Name = "White",
                            Color = "#FFFFFF",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Belt()
                        {
                            Name = "Yellow",
                            Color = "#F9FF00",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Belt()
                        {
                            Name = "Orange",
                            Color = "#DE7F00",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Belt()
                        {
                            Name = "Green",
                            Color = "#00FF21",
                            CreatedDate = DateTime.UtcNow
                        }
                    });
                    context.SaveChanges();
                }

                // Bootcamp Group
                if (!context.bootcamp_groups.Any())
                {
                    context.bootcamp_groups.AddRange(new List<BootcampGroup>()
                    {
                        new BootcampGroup()
                        {
                            Name = "Java Bootcamp",
                            Description = "Bootcamp for Java",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampGroup()
                        {
                            Name = "DotNet Bootcamp",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampGroup()
                        {
                            Name = "AngularJS Bootcamp",
                            Description = "Bootcamp for Angular",
                            IsActive = false,
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampGroup()
                        {
                            Name = "ReactJS Bootcamp",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow
                        }
                    });
                    context.SaveChanges();
                }

                // Syllabus
                if (!context.syllabuses.Any())
                {
                    context.syllabuses.AddRange(new List<Syllabus>()
                    {
                        new Syllabus()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            Name = "Framework A",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            Name = "Framework B",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            Name = "Tech A",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            Name = "Tech B",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            Name = "Design Pattern A",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            Name = "Design Pattern B",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            Name = "Architecture A",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            Name = "Architecture B",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            Name = "Syllabus X",
                            CreatedDate = DateTime.UtcNow
                        }
                    });
                    context.SaveChanges();
                }

                // User_bootcamp
                if (!context.user_bootcamps.Any())
                {
                    context.user_bootcamps.AddRange(new List<UserBootcamp>()
                    {
                        new UserBootcamp()
                        {
                            UserId = 1,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 2,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 3,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 4,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 5,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 1,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 1,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = true,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 2,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = true,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 3,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = true,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 4,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = true,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 5,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = true,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 6,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 7,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 8,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 9,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 10,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = false,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 6,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = true,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 7,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = true,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 8,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = true,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 9,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = true,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            UserId = 10,
                            BootcampGroupId = new Random().Next(1, 4),
                            IsActive = true,
                            JoinDate = DateTime.Today,
                            CreatedDate = DateTime.UtcNow
                        }
                    });
                    context.SaveChanges();
                }

                // Bootcamp_member:
                if (!context.bootcamp_members.Any())
                {
                    context.bootcamp_members.AddRange(new List<BootcampMember>()
                    {
                        new BootcampMember()
                        {
                            FullName = "Member 1",
                            CreatedDate = DateTime.Now
                        },
                        new BootcampMember()
                        {
                            FullName = "Member 2",
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampMember()
                        {
                            FullName = "Member 3",
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampMember()
                        {
                            FullName = "Member 4",
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampMember()
                        {
                            FullName = "Member 5",
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampMember()
                        {
                            FullName = "Member 6",
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampMember()
                        {
                            FullName = "Member 7",
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampMember()
                        {
                            FullName = "Member 8",
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampMember()
                        {
                            FullName = "Member 9",
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampMember()
                        {
                            FullName = "Member 10",
                            CreatedDate = DateTime.UtcNow
                        },
                    });
                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                // Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.CDCManager))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.CDCManager));

                if (!await roleManager.RoleExistsAsync(UserRoles.BootcampMember))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.BootcampMember));

                // User dummy for CDC Manager:
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string cdcManagerEmail = "cdcmanager@mitrais.com";

                var cdcManagerUser = await userManager.FindByEmailAsync(cdcManagerEmail);
                if (cdcManagerUser == null)
                {
                    var newCdcManagerUser = new ApplicationUser()
                    {
                        FullName = "CDC Manager",
                        UserName = "cdc-manager",
                        Email = cdcManagerEmail,
                        EmailConfirmed = true
                    };

                    await userManager.CreateAsync(newCdcManagerUser, "Mitrais@123#");
                    await userManager.AddToRoleAsync(newCdcManagerUser, UserRoles.CDCManager);
                }

                // User dummy for Bootcamp Member:
                string bootcampMemberEmail = "member@mitrais.com";

                var bootcampMemberUser = await userManager.FindByEmailAsync(bootcampMemberEmail);
                if (bootcampMemberUser == null)
                {
                    var newBootcampMemberUser = new ApplicationUser()
                    {
                        FullName = "Bootcamp Member",
                        UserName = "bootcamp-member",
                        Email = bootcampMemberEmail,
                        EmailConfirmed = true
                    };

                    await userManager.CreateAsync(newBootcampMemberUser, "Mitrais@321#");
                    await userManager.AddToRoleAsync(newBootcampMemberUser, UserRoles.BootcampMember);
                }
            }
        }
    }
}