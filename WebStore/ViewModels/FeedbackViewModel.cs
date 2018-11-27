using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.ViewModels
{
    public class FeedbackViewModel
    {
        public IEnumerable<Feedback> Feedbacks { get; set; }
        public Feedback PostData { get; set; }
    }
}
