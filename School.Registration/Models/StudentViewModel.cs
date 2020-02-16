using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Registration.Models
{
    public class StudentViewModel
    {
        [Required]
        [MinLength(5)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(5)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(10)]
        public string Message { get; set; }
    }
}
