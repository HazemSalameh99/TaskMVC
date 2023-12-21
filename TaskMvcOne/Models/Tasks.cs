using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcOne.Models
{
    public class Tasks
    {
        [Key]
        public int TasksId { get; set; }
        [Required(ErrorMessage ="Enter The Task Title")]
        [Display(Name ="Task Title")]
        [DataType(DataType.Text)]
        public string TaskTitle { get; set; }
        [Required(ErrorMessage ="Enter the Start Date")]
        [Display(Name ="Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Enter the End Date")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
