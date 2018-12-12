using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels
{
    public class SignInViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public String UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}
