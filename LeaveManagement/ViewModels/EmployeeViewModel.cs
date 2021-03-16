using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.ViewModels
{
    public class EmployeeViewModel
    {

        public EmployeeViewModel()
        {
            Request = UserName = "unTouched";
        }

        public string UserName { get; set; }
        public string Department { get; set; }
        public string Request { get; set; }
    }
}
