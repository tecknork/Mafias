using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Api.Hubs
{
    [HubName("student")]
    public class StudentHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}