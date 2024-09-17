using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Session_1.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Field Required")]

        [StringLength(15, MinimumLength = 3 ,ErrorMessage = "Name length must be between 3 and 15")]
        public string Name { get; set; }


        [Range(17, 40)]
        public int Age { get; set; }


        [Required]
        [RegularExpression(@"[a-zA-Z0-9]+@[a-zA-Z]+.[a-zA-Z]{2,4}", ErrorMessage = "Invalid Email Format.")]
        [Remote(action: "IsEmailAvailable", controller: "Student")]
        public string Email { get; set; }


        [ForeignKey("Department")]
        public int DeptId { get; set; }

        public virtual Department Department { get; set; }

        public override string ToString()
        {
            return $"Student Id: {Id}\n Name: {Name} \n Age: {Age}\n Dept Id:{DeptId}";
        }
    }
}
