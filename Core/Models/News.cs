﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Models
{
    public partial class News
    {
        public News()
        {
            NewsTagMap = new HashSet<NewsTagMap>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Title { get; set; }
        public string NewsContent { get; set; }
        [StringLength(250)]
        public string Link { get; set; }
        public int? CategoryId { get; set; }
        public int? LanguageId { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpadatDate { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("News")]
        public virtual Category Category { get; set; }
        [ForeignKey(nameof(LanguageId))]
        [InverseProperty("News")]
        public virtual Language Language { get; set; }
        [InverseProperty("News")]
        public virtual ICollection<NewsTagMap> NewsTagMap { get; set; }
    }
}