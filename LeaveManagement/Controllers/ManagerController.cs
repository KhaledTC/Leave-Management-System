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

            ManagerViewModel model = new ManagerViewModel();

            var users = userManager.Users.ToList();
            foreach (var user in users)
                if (user.Department == manager.Department && user.Role != "Manager")
                    model.Employees.Add(user);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AcceptRequest(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            user.LeaveRequest = "Accepted";
            await userManager.UpdateAsync(user);
            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> RejectRequest(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            user.LeaveRequest = "Rejected";
            await userManager.UpdateAsync(user);
            return RedirectToAction("index");
        }

    }
}
