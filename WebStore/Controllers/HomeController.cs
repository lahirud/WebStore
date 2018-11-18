using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;

        public HomeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var cakes = _cakeRepository.GetAllCakes();

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to my Cake Shop!",
                Cakes = cakes.ToList()
            };

            return View(homeViewModel);
        }
    }
}
