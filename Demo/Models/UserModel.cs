using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class UserModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required for logging in!")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Minimum username length is 4 and maximum is 20")]
        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Passowrd is required!")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Wrong! Minimum password length is 4 and maximum 100")]  
        public string Password { get; set; }
        public List<string> Notes { get; set; }

    }
}