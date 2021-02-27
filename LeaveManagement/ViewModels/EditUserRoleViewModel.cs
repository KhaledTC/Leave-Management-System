using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.ViewModels
{
    public class EditUserRoleViewModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
    }
}
