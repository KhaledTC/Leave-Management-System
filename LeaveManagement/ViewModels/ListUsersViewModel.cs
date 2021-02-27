using LeaveManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.ViewModels
{
    public class ListUsersViewModel
    {

        public ListUsersViewModel()
        {
            Users = new List<AppUser>();
        }

        public List<AppUser> Users { get; set; }
        public string Role { get; set; }
    }
}
