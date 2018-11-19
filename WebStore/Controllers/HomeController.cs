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
        private IRepository _cakeRepository;

        public HomeController(IRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Welcome to Cake Shop!";
            var cakes = _cakeRepository.GetAllCakes();
            return View(cakes);
        }
    }
}
