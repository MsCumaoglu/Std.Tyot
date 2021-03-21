﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            College = new HashSet<College>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Link { get; set; }
        public string About { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        public int UniversityId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpadatDate { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }

        [ForeignKey(nameof(UniversityId))]
        [InverseProperty("Faculty")]
        public virtual University University { get; set; }
        [InverseProperty("Faculty")]
        public virtual ICollection<College> College { get; set; }
    }
}