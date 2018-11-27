using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetAll();
        void AddFeedback(Feedback feedback);
    }
}
