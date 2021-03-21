﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Models
{
    public partial class ExamUniversity
    {
        public ExamUniversity()
        {
            ExamLanguageMap = new HashSet<ExamLanguageMap>();
        }

        [Key]
        public int Id { get; set; }
        public int? UniversityId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string Contentt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateToApplication { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateToAppllication { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExamDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateResualtExam { get; set; }
        [StringLength(150)]
        public string Link { get; set; }
        [StringLength(250)]
        public string LinkPastYearExams { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
        [Column("isStart")]
        public bool? IsStart { get; set; }
        public bool? Type { get; set; }
        [StringLength(1)]
        public string AgeOfExam { get; set; }
        public string ExamPlace { get; set; }
        [StringLength(50)]
        public string ExamPrice { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpadatDate { get; set; }

        [ForeignKey(nameof(UniversityId))]
        [InverseProperty("ExamUniversity")]
        public virtual University University { get; set; }
        [InverseProperty("Language")]
        public virtual ICollection<ExamLanguageMap> ExamLanguageMap { get; set; }
    }
}