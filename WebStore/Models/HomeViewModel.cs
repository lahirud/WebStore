using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Cake> Cakes { get; set; }
    }
}
