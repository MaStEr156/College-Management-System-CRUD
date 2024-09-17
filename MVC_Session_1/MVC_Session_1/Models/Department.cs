using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Session_1.Models
{
    public class Department
    {
        [Required(ErrorMessage = "Field Required")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }

        [Required(ErrorMessage = "Field Required")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Department Name length must be between 2 and 10")]
        public string DeptName {  get; set; }

        [Range(20, 100, ErrorMessage ="Capacity must be between 20 and 100")]
        public int Capacity { get; set; }

        public virtual List<Student> Students { get; set; }

        public override string ToString()
        {
            return $"Dept Id: {DeptId} \nName: {DeptName} \nCapacity: {Capacity}";
        }

    }
}
