using LeaveManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.ViewModels
{
    public class ManagerViewModel
    {
        public ManagerViewModel()
        {
            Employees = new List<AppUser>();
        }
        public List<AppUser> Employees { get; set; }
        public string Department { get; set; }
    }
}
