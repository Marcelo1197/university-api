using System.ComponentModel.DataAnnotations;

namespace UniversityOB.API.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public int StudentId { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public DateTime? BirthDate { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
