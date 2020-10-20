using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCWebAppDemo.Models
{
    public class LoginDetails
    {
        [Required(ErrorMessage = "Username cannot be Empty")]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "User Name")]
        public string UserID { get; set; }
      
        [Required(ErrorMessage = "Password cannot be empty")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        public string Password { get; set; }
    }
}
