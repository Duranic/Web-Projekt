using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace Spam_Detection_Chat
{
    public class MyHub : Hub
    {
        private SpamChecker spamChecker = new SpamChecker();
        public async Task Send(String name, String message)
        {

            if (await spamChecker.CheckSpam(message))
            {
                Clients.All.addNewMessage(name, message);
                Clients.All.markSpam();
            }
            else
            {
                Clients.All.addNewMessage(name, message);
            }

        }
    }
}