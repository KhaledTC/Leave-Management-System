using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            LeaveRequest = "unTouched";
        }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public GenderEnum Gender { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Role { get; set; }
        public string LeaveRequest { get; set; }
    }
}
