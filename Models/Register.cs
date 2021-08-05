using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleLoginC.Models
{
    public class Register
        {
               [Required]
                [MinLength(4)]
                public string FirstName {get; set;}

                [Required]
                [MinLength(4)]
                public string LastName {get; set;}

                [Required]
                [Range(18,120 , ErrorMessage = "You no of age or u dead")]
                public int Age {get; set;}

                [Required]
                [EmailAddress]
                public string Email {get; set;}

                [Required]
                [DataType(DataType.Password)]
                public string Password {get; set;}

        }
}