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
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public EmployeeController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await userManager.GetUserAsync(User);

            LeaveRequestViewModel model = new LeaveRequestViewModel()
            {
                UserName = user.UserName,
                Request = user.LeaveRequest
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitRequest(LeaveRequestViewModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            user.LeaveRequest = model.Request;
            await userManager.UpdateAsync(user);
            return RedirectToAction("Index");
        }
    }
}
