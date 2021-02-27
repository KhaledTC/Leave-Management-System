using LeaveManagement.Models;
using LeaveManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AppUser> userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager,
                                        UserManager<AppUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult ManageUsers()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            await userManager.DeleteAsync(user);
            return RedirectToAction("ListUsers", new { role = user.Role });
        }


        [HttpGet]
        public IActionResult ListUsers(string role)
        {
            ListUsersViewModel model = new ListUsersViewModel()
            {
                Role = role,
                Users = userManager.Users.ToList()
            };

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> EditUserRole(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User can't be found";
                return View("NotFound");
            }
            EditUserRoleViewModel model = new EditUserRoleViewModel()
            {
                Id = user.Id,
                Username = user.UserName,
                Role = user.Role
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserRole(EditUserRoleViewModel newRole)
        {
            var user = await userManager.FindByIdAsync(newRole.Id);

            await userManager.RemoveFromRoleAsync(user, user.Role);
            await userManager.AddToRoleAsync(user, newRole.Role);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User {newRole.Username} can't be found";
                return View("NotFound");
            }

            user.UserName = newRole.Username;
            user.Role = newRole.Role;
            await userManager.UpdateAsync(user);
            return RedirectToAction("ListUsers", new { role = user.Role });
        }

    }
}
