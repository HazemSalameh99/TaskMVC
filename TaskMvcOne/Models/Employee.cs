using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcOne.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Enter The Employee Name")]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Employee Birth date")]
        [Display(Name = "Employee Birth date")]
        [DataType(DataType.Date)]
        public DateTime EmpBirthdate { get; set; }
        [Required(ErrorMessage ="Enter Phone Number")]
        [Display(Name ="Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int EmpPhoneNumber { get; set; }
        [Required(ErrorMessage = "Enter national Id")]
        public string NationalId { get; set; }
        [Required(ErrorMessage = "Enter nationalties")]
        public string  Nationalties { get; set; }
        [Display(Name ="Personal Photo")]
        public string PersonalPhoto { get; set; }
        [Required(ErrorMessage ="Enter The Entry Date")]
        [Display(Name ="Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        [Required(ErrorMessage ="Enter The Password")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Tasks> Tasks { get; set; }

    }
}
