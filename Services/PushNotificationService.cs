using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Services
{
    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string Action, User user)
        {
            Console.WriteLine($"Push Notificatoin Service : User (id : {user.Id}) {Action} ");
        }
    }
}
