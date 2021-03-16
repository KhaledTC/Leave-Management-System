using LeaveManagement.Models;
using LeaveManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles = "Manager")]
    public class ManagerController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public ManagerController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var manager = await userManager.GetUserAsync(User);
            var users = userManager.Users.ToList();

            ManagerViewModel model = new ManagerViewModel()
            {
                Employees = (from user in users where user.Department == manager.Department && user.Role != "Manager" select user).ToList(),
                Department = manager.Department
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AcceptRequest(string username)
        {
            var employee = await userManager.FindByNameAsync(username);
            employee.LeaveRequest = "Accepted";
            await userManager.UpdateAsync(employee);
            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> RejectRequest(string username)
        {
            var employee = await userManager.FindByNameAsync(username);
            employee.LeaveRequest = "Rejected";
            await userManager.UpdateAsync(employee);
            return RedirectToAction("index");
        }

    }
}
