using System;
using System.ComponentModel.DataAnnotations;
using form_submission.Validations;

namespace form_submission.Models
{
    public class User
    {
        // ~~~~~~~~~~Fields~~~~~~~~~~
        [Required]
        [MinLength(2)]
        // the line below will display as the label
        [Display(Name = "First Name:")] 
        public string FirstName { get; set; }
        
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }
        
        [Required]
        [Range(0,100)]
        public int Age {get; set;}
        
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get; set;}

        [PastDate]
        public DateTime Birthdate {get; set;}
        
        // ~~~~~~~~~~Constructors~~~~~~~~~~
        // None, because we're doing it through asp-for in the view!

        // ~~~~~~~~~~ Other Functions ~~~~~~~~~~
    }
}