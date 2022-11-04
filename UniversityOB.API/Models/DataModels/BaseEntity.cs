﻿using System.ComponentModel.DataAnnotations;

namespace UniversityOB.API.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string CreatedBy { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; } = DateTime.Now; 

        public string UpdatedBy { get; set; } = string.Empty;

        public DateTime? UpdatedAt { get; set; }

        public string DeteledBy { get; set; } = string.Empty;

        public DateTime? DeletedAt { get; set; }

        public Boolean IsDeleted { get; set; } = false;
    }
}
