using System.ComponentModel.DataAnnotations;

namespace UniversityOB.API.Models.DataModels
{
    public class Chapter : BaseEntity
    {
        public int CourseId { get; set; }

        [Required]
        public virtual Course Course { get; set; } = new Course();
        [Required]
        public string List = string.Empty;

    }
}
