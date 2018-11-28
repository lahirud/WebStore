using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "The email address is not entered in a correct format")]
        public string Email { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "Your message is required")]
        public string Message { get; set; }
    }
}
