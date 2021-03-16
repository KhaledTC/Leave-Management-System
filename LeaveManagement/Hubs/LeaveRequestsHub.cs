using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Hubs
{
    public class LeaveRequestsHub : Hub
    {
        public async Task SendLeaveRequest(string department, string employeeName)
        {
            string method = department + "managers";
            await Clients.All.SendAsync(method, department, employeeName);
        }

        public async Task RespondToLeaveRequest(string employeeName)
        {
            await Clients.All.SendAsync("RespondToLeaveRequest", employeeName);
        }
    }
}
