using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Services
{
    public class EmailService : INotificationService
    {
        public void SendNotification(string Action, User user)
        {
            Console.WriteLine($"Email Service : User (id : {user.Id}) {Action} ");
        }
    }
}
