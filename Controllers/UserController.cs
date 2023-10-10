using Bank.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    public class UserController : Controller
    {
        private readonly Users user = new Users()
        {
            Id = 1,
            UserName = "Sravs",
            Email = "sravs@gmail.com",
            Password = "sravs@123"
        };
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Users model)
        {
            if (ModelState.IsValid && model.UserName == user.UserName && model.Email == user.Email && model.Password == user.Password)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            ModelState.AddModelError("", "Invalid username or Password");
            return View(model);
        }
    }
}