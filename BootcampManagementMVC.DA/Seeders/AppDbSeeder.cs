using BootcampManagementMVC.Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampManagementMVC.DA
{
    public class AppDbSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Stage
                if (!context.stages.Any())
                {
                    context.stages.AddRange(new List<Stage>()
                    {
                        new Stage()
                        {
                            Name = "White",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Stage()
                        {
                            Name = "Yellow",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Stage()
                        {
                            Name = "Orange",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Stage()
                        {
                            Name = "Green",
                            CreatedDate = DateTime.UtcNow
                        }
                    });
                    context.SaveChanges();
                }

                // BootcampGroup
                if (!context.bootcamp_groups.Any())
                {
                    context.bootcamp_groups.AddRange(new List<BootcampGroup>()
                    {
                        new BootcampGroup()
                        {
                            Name = "Java",
                            Description = "Bootcamp for Java",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampGroup()
                        {
                            Name = "DotNet",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampGroup()
                        {
                            Name = "AngularJS",
                            Description = "Bootcamp for Angular",
                            IsActive = false,
                            CreatedDate = DateTime.UtcNow
                        },
                        new BootcampGroup()
                        {
                            Name = "ReactJS",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow
                        }
                    });
                    context.SaveChanges();
                }

                // Syllabus
                if (!context.syllabuses.Any())
                {
                    BootcampGroup bootcampGroupId1 = context.bootcamp_groups.Where(n => n.Name == "Java").FirstOrDefault();
                    BootcampGroup bootcampGroupId2 = context.bootcamp_groups.Where(n => n.Name == "DotNet").FirstOrDefault();
                    BootcampGroup bootcampGroupId3 = context.bootcamp_groups.Where(n => n.Name == "AngularJS").FirstOrDefault();
                    BootcampGroup bootcampGroupId4 = context.bootcamp_groups.Where(n => n.Name == "ReactJS").FirstOrDefault();

                    context.syllabuses.AddRange(new List<Syllabus>()
                    {
                        new Syllabus()
                        {
                            BootcampGroupId = bootcampGroupId1.Id,
                            Name = "Java",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = bootcampGroupId2.Id,
                            Name = "DotNet",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = bootcampGroupId3.Id,
                            Name = "AngularJS",
                            CreatedDate = DateTime.UtcNow
                        },
                        new Syllabus()
                        {
                            BootcampGroupId = bootcampGroupId4.Id,
                            Name = "ReactJS",
                            CreatedDate = DateTime.UtcNow
                        }
                    });
                    context.SaveChanges();
                }

                // UserBootcamp
                if (!context.user_bootcamps.Any())
                {
                    context.user_bootcamps.AddRange(new List<UserBootcamp>()
                    {
                        new UserBootcamp()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            UserId = 1,
                            IsActive = true,
                            JoinDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            UserId = 1,
                            IsActive = false,
                            JoinDate = DateTime.UtcNow
                        },
                        new UserBootcamp()
                        {
                            BootcampGroupId = new Random().Next(1, 4),
                            UserId = 3,
                            IsActive = true,
                            JoinDate = DateTime.UtcNow
                        }
                    });
                    context.SaveChanges();
                }

                // SylabusTask
                if (!context.syllabus_tasks.Any())
                {
                    context.syllabus_tasks.AddRange(new List<SyllabusTask>()
                    {
                        new SyllabusTask()
                        {
                            SyllabusId = 2,
                            StageId = 1,
                            Title = ".NET Overview and tools",
                            Description = "Understand what is .NET",
                            DurationEstimate = 1
                        },
                        new SyllabusTask()
                        {
                            SyllabusId = 2,
                            StageId = 2,
                            Title = ".NET Fundamental",
                            Description = "",
                            DurationEstimate = 4
                        },
                        new SyllabusTask()
                        {
                            SyllabusId = 2,
                            StageId = 3,
                            Title = "Real-time Apps",
                            Description = "",
                            DurationEstimate = 4
                        }
                    });
                    context.SaveChanges();
                }

                // BootcampMember:
                if (!context.bootcamp_members.Any())
                {
                    context.bootcamp_members.AddRange(new List<BootcampMember>()
                    {
                        new BootcampMember()
                        {
                            FullName = "Adaline Reichel",
                            Grade = "PG"
                        },
                        new BootcampMember()
                        {
                            FullName = "Noemy Vandervort",
                            Grade = "PG"
                        },
                        new BootcampMember()
                        {
                            FullName = "Lexi OConner",
                            Grade = "AP"
                        },
                        new BootcampMember()
                        {
                            FullName = "Gracie Weber",
                            Grade = "AP"
                        },
                        new BootcampMember()
                        {
                            FullName = "Roscoe Johns",
                            Grade = "AP"
                        },
                        new BootcampMember()
                        {
                            FullName = "Emmett Lebsack",
                            Grade = "AN"
                        },
                        new BootcampMember()
                        {
                            FullName = "Keegan Thiel",
                            Grade = "AN"
                        },
                        new BootcampMember()
                        {
                            FullName = "Wellington Koelpin",
                            Grade = "AN"
                        },
                        new BootcampMember()
                        {
                            FullName = "Karley Kiehn V",
                            Grade = "PG"
                        },
                        new BootcampMember()
                        {
                            FullName = "John Doe",
                            Grade = "AP"
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