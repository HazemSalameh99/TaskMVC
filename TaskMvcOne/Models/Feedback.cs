using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcOne.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        [Required(ErrorMessage =("Enter First Name"))]
        [Display(Name ="First Name")]
        public string  SenderFName { get; set; }
        [Required(ErrorMessage = ("Enter Last Name"))]
        [Display(Name = "Last Name")]
        public string SenderLName { get; set; }
        [Required(ErrorMessage = ("Enter Sender Email"))]
        [Display(Name = "Sender Name")]
        [DataType(DataType.EmailAddress)]
        public string SenderEmail { get; set; }
        [Required(ErrorMessage = ("Enter Message"))]
        [Display(Name = "Message")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
        public int ManegarId { get; set; }
        public Manegar Manegar { get; set; }


    }
}
