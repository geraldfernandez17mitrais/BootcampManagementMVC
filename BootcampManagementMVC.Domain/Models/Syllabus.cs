﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampManagementMVC.Domain.Models
{
    public class Syllabus : AuditAble
    {
        [Key]
        public int Id { get; set; }

        // HasOne Relationships
        public int BootcampGroupId { get; set; }

        [ForeignKey(nameof(BootcampGroupId))]
        public BootcampGroup BootcampGroup { get; set; }

        // Another field
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(45, ErrorMessage = "Name must be less than 45 characters.")]
        public string Name { get; set; }

        // Relationships
        public List<SyllabusTask> SyllabusTasks { get; set; }
    }
}