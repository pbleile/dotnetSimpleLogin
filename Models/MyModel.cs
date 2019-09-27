using System;
using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
    public class RegUser
    {
        [Required]
        [MinLength(2)]
        [Display(Name="First Name")]
        public string FirstName{get;set;}
        [Required]
        [MinLength(2)]
        [Display(Name="Last Name")]
        public string LastName{get;set;}
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email")]
        public string Email{get;set;}
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Choose Password")]
        public string Password{get;set;}
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword{get;set;}
    }
    public class LogUser{
        [Required]
        [Display(Name="Email")]
        public string Email{get;set;}
        [Required]
        [Display(Name="Password")]
        public string Password{get;set;}
    }
}