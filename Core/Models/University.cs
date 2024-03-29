﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Models
{
    public partial class University
    {
        public University()
        {
            AcceptedExamUniversityMap = new HashSet<AcceptedExamUniversityMap>();
            AcceptedUniversityExamAcceptedExamUniversity = new HashSet<AcceptedUniversityExam>();
            AcceptedUniversityExamUniversity = new HashSet<AcceptedUniversityExam>();
            ExamUniversity = new HashSet<ExamUniversity>();
            Faculty = new HashSet<Faculty>();
            LnaguageUniversityMap = new HashSet<LnaguageUniversityMap>();
            UniversityComment = new HashSet<UniversityComment>();
            UniversityGalery = new HashSet<UniversityGalery>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string OriganName { get; set; }
        [StringLength(150)]
        public string ArName { get; set; }
        [StringLength(50)]
        public string Website { get; set; }
        public int? NumberOfStudent { get; set; }
        public int? NumberOfReStudent { get; set; }
        public int? GlobalPlace { get; set; }
        public int? LocalPlace { get; set; }
        public int? FoundYear { get; set; }
        [StringLength(5)]
        public string AcceptanceRate { get; set; }
        public string Map { get; set; }
        public string About { get; set; }
        [StringLength(50)]
        public string Logo { get; set; }
        [StringLength(50)]
        public string Banner { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        public bool? Type { get; set; }
        public int? CityId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpadatDate { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(CityId))]
        [InverseProperty("University")]
        public virtual City City { get; set; }
        [InverseProperty("University")]
        public virtual ICollection<AcceptedExamUniversityMap> AcceptedExamUniversityMap { get; set; }
        [InverseProperty(nameof(AcceptedUniversityExam.AcceptedExamUniversity))]
        public virtual ICollection<AcceptedUniversityExam> AcceptedUniversityExamAcceptedExamUniversity { get; set; }
        [InverseProperty(nameof(AcceptedUniversityExam.University))]
        public virtual ICollection<AcceptedUniversityExam> AcceptedUniversityExamUniversity { get; set; }
        [InverseProperty("University")]
        public virtual ICollection<ExamUniversity> ExamUniversity { get; set; }
        [InverseProperty("University")]
        public virtual ICollection<Faculty> Faculty { get; set; }
        [InverseProperty("Univ")]
        public virtual ICollection<LnaguageUniversityMap> LnaguageUniversityMap { get; set; }
        [InverseProperty("University")]
        public virtual ICollection<UniversityComment> UniversityComment { get; set; }
        [InverseProperty("Uinversity")]
        public virtual ICollection<UniversityGalery> UniversityGalery { get; set; }
    }
}