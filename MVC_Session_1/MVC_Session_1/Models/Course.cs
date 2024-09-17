using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Session_1.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // ID as identity
        public int CourseId { get; set; }


        [Required(ErrorMessage = "*")]
        public string CourseName { get; set; }



        [Range(12, 20, ErrorMessage = "Duration must be between 12 and 20 hours.")]
        public int Duration { get; set; }

        public bool Status { get; set; } = false;

        // Relation with Department (if a course is linked to a department)
        [ForeignKey("Department")]
        public int DeptNo { get; set; }
        public virtual Department Department { get; set; }

        public override string ToString()
        {
            return $"Course ID: {CourseId}  Course Name: {CourseName}  Duration: {Duration} hours";
        }
    }
}
