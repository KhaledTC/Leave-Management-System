using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.ViewModels
{
    public class LeaveRequestViewModel
    {

        public LeaveRequestViewModel()
        {
            Request = UserName = "unTouched";
        }

        public string UserName { get; set; }
        public string Request { get; set; }
    }
}
