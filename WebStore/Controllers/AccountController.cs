using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebStore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        // GET: /<controller>/
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(SignInViewModel logInViewModel)
        {
            if (!ModelState.IsValid)
                return View(logInViewModel);

            var user = await _userManager.FindByNameAsync(logInViewModel.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, logInViewModel.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "User name/password not found");
            return View(logInViewModel);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(SignInViewModel logInViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = logInViewModel.UserName };
                var result = await _userManager.CreateAsync(user, logInViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }


                if (result.Errors.Any())
                {
                    var errorMassage = new StringBuilder();
                    foreach (var error in result.Errors)
                    {
                        errorMassage.Append($", {error.Description}");
                    }
                    ModelState.AddModelError("", errorMassage.ToString());
                }
            }
            return View(logInViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
