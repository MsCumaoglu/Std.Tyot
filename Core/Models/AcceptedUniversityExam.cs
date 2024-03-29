﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Models
{
    public partial class AcceptedUniversityExam
    {
        [Key]
        public int Id { get; set; }
        public int? UniversityId { get; set; }
        public int? AcceptedExamUniversityId { get; set; }
        public bool? Type { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpadatDate { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [ForeignKey(nameof(AcceptedExamUniversityId))]
        [InverseProperty("AcceptedUniversityExamAcceptedExamUniversity")]
        public virtual University AcceptedExamUniversity { get; set; }
        [ForeignKey(nameof(UniversityId))]
        [InverseProperty("AcceptedUniversityExamUniversity")]
        public virtual University University { get; set; }
    }
}