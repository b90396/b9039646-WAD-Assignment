using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using b9039646_WAD_Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace b9039646_WAD_Assignment.Controllers
{
    public class AuthenticationController : Controller
    {

        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly SignInManager<User> signinManager;

        public AuthenticationController(UserManager<User> userManager, RoleManager<Role> roleManager,
            SignInManager<User> signinManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signinManager = signinManager;
        }


        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Register obj)
        {
            if (ModelState.IsValid)
            {
                if (!roleManager.RoleExistsAsync("Admin").Result)
                {
                    Role role = new Role();
                    role.Name = "Admin";
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }

                User user = new User();
                user.UserName = obj.UserName;
                user.Email = obj.Email;
                //user.BirthDate = obj.BirthDate;

                IdentityResult result = userManager.CreateAsync
                (user, obj.Password).Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                    return RedirectToAction("SignIn", "Authentication");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid user details");
                }
            }
            return View(obj);
        }


    }
}
