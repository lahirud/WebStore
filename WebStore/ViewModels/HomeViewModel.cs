using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public IEnumerable<Cake> Cakes { get; set; }
    }
}
