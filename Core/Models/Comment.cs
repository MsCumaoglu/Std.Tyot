﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Models
{
    public partial class Comment
    {
        [Key]
        public int Id { get; set; }
        public string CommentContenet { get; set; }
        public int? NumberLike { get; set; }
        public int? ArticleId { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpadatDate { get; set; }

        [ForeignKey(nameof(ArticleId))]
        [InverseProperty(nameof(Artical.Comment))]
        public virtual Artical Article { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Comment")]
        public virtual User User { get; set; }
    }
}