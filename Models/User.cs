using System.ComponentModel.DataAnnotations;
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
        
        // ~~~~~~~~~~Constructors~~~~~~~~~~
        // public User() { }
        // public User(string firstName, string lastName, int age, string email, string password)
        // {
        //     FirstName = firstName;
        //     LastName = lastName;
        //     Age = age;
        //     Email = email;
        //     Password = password;
        // }

        // ~~~~~~~~~~ Other Functions ~~~~~~~~~~
        // public string String()
        // {
        //     return FullName + " from " + Location + " likes " + Language + ". They said " + Comment + ".";
        // }
    }
}