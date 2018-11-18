using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> GetAllCakes();

        Cake GetCakeById(int id);
    }
}
