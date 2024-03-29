﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Models
{
    public partial class Following
    {
        [Key]
        public int Id { get; set; }
        public int? FollowerUser { get; set; }
        public int? FollowingUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequsetDate { get; set; }
        [Column("isAccepted")]
        public bool? IsAccepted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AcceptDate { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpadatDate { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [ForeignKey(nameof(FollowerUser))]
        [InverseProperty(nameof(User.FollowingFollowerUserNavigation))]
        public virtual User FollowerUserNavigation { get; set; }
        [ForeignKey(nameof(FollowingUser))]
        [InverseProperty(nameof(User.FollowingFollowingUserNavigation))]
        public virtual User FollowingUserNavigation { get; set; }
    }
}