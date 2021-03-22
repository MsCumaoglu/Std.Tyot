﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Models
{
    public partial class UserSetting
    {
        [Key]
        public int Id { get; set; }
        public bool? NameHidden { get; set; }
        public bool? UserNameHidden { get; set; }
        public bool? EmailHidden { get; set; }
        public bool? BirthDateHidden { get; set; }
        public bool? PhoneHidden { get; set; }
        public bool? AdressHidden { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpadatDate { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserSetting")]
        public virtual User User { get; set; }
    }
}