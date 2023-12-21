using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcOne.Models
{
    public class Manegar
    {
        [Key]
        public int ManegarId { get; set; }
        [Required(ErrorMessage ="Enter The Manger Name")]
        [Display(Name ="Manegar")]
        public string ManegarName { get; set; }
        [Required(ErrorMessage ="Enter Password")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
