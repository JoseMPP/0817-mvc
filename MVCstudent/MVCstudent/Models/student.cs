using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

namespace MVCstudent.Models
{
    public class student
    {
        [Key]
        public int studentID { get; set; }
        [Required]
        [Display(Description ="LastName")]
        public string LastName { get; set; }
        [Required]
        [Display(Description ="First Name")]
        public string FirstName { get; set; }
    }
}