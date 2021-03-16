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
            var employee = await userManager.GetUserAsync(User);

            EmployeeViewModel model = new EmployeeViewModel()
            {
                UserName = employee.UserName,
                Request = employee.LeaveRequest,
                Department = employee.Department
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitRequest(EmployeeViewModel model)
        {
            var employee = await userManager.FindByNameAsync(model.UserName);
            employee.LeaveRequest = model.Request;
            await userManager.UpdateAsync(employee);
            return RedirectToAction("Index");
        }
    }
}
