using CourseLibrary.API.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescription]
    public class CourseForCreationDto //: IValidatableObject
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1500)]
        public string Description { get; set; }
    }
}
