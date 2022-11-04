using System.ComponentModel.DataAnnotations;

namespace UniversityOB.API.Models.DataModels
{
    public enum CourseLevel
    {
        Basic,
        Medium,
        Advanced
    }

    public class Course : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [MaxLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        public string LongDescription { get; set; } = string.Empty;

        public string TargetAudience { get; set; } = string.Empty;

        public string Objectives { get; set; } = string.Empty;

        public string Requisites { get; set; } = string.Empty;

        public CourseLevel Level { get; set; } = CourseLevel.Basic;
    }
}
