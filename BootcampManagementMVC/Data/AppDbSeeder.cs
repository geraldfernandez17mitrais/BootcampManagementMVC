using BootcampManagementMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BootcampManagementMVC.Data
{
    public class AppDbSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
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
                            Name = "Entry"
                        },
                        new StatusLearning()
                        {
                            Name = "On Progress"
                        },
                        new StatusLearning()
                        {
                            Name = "Finish"
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
                            Color = "#FFFFFF"
                        },
                        new Belt()
                        {
                            Name = "Yellow",
                            Color = "#F9FF00"
                        },
                        new Belt()
                        {
                            Name = "Orange",
                            Color = "#DE7F00"
                        },
                        new Belt()
                        {
                            Name = "Green",
                            Color = "#00FF21"
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
                            Is_active = true
                        },
                        new BootcampGroup()
                        {
                            Name = "DotNet Bootcamp",
                            Is_active = true
                        },
                        new BootcampGroup()
                        {
                            Name = "AngularJS Bootcamp",
                            Description = "Bootcamp for Angular",
                            Is_active = false
                        },
                        new BootcampGroup()
                        {
                            Name = "ReactJS Bootcamp",
                            Is_active = true
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
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Name = "Framework A"
                        },
                        new Syllabus()
                        {
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Name = "Framework B"
                        },
                        new Syllabus()
                        {
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Name = "Tech A"
                        },
                        new Syllabus()
                        {
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Name = "Tech B"
                        },
                        new Syllabus()
                        {
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Name = "Design Pattern A"
                        },
                        new Syllabus()
                        {
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Name = "Design Pattern B"
                        },
                        new Syllabus()
                        {
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Name = "Architecture A"
                        },
                        new Syllabus()
                        {
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Name = "Architecture B"
                        },
                        new Syllabus()
                        {
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Name = "Syllabus X"
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
                            User_id = 1,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 2,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 3,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 4,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 5,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 1,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 1,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = true,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 2,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = true,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 3,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = true,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 4,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = true,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 5,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = true,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 6,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 7,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 8,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 9,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 10,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = false,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 6,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = true,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 7,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = true,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 8,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = true,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 9,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = true,
                            Join_date = DateTime.Today
                        },
                        new UserBootcamp()
                        {
                            User_id = 10,
                            Bootcamp_group_id = new Random().Next(1, 4),
                            Is_active = true,
                            Join_date = DateTime.Today
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
                            Full_name = "Member 1"
                        },
                        new BootcampMember()
                        {
                            Full_name = "Member 2"
                        },
                        new BootcampMember()
                        {
                            Full_name = "Member 3"
                        },
                        new BootcampMember()
                        {
                            Full_name = "Member 4"
                        },
                        new BootcampMember()
                        {
                            Full_name = "Member 5"
                        },
                        new BootcampMember()
                        {
                            Full_name = "Member 6"
                        },
                        new BootcampMember()
                        {
                            Full_name = "Member 7"
                        },
                        new BootcampMember()
                        {
                            Full_name = "Member 8"
                        },
                        new BootcampMember()
                        {
                            Full_name = "Member 9"
                        },
                        new BootcampMember()
                        {
                            Full_name = "Member 10"
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
