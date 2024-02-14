using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public class UserManagement
    {
        private Dictionary<int, User> users = new Dictionary<int, User>();

        public event Action<string> UserAction;

        public void AddUser(User user)
        {
            users[user.Id] = user;
            UserAction.Invoke($"user {user.Id} added");
        }

        public void RemoveUser(int id)
        {
            if (users.ContainsKey(id))
            {
                var user = users[id];
                users.Remove(id);
                UserAction.Invoke($"User {user.Id} has been removed");
            }
            else
            {
                Console.WriteLine("No User Found");
            }

            
        }

        public void UpdateUser(int id, string key, string value)
        {
            if (users.ContainsKey(id))
            {
                var user = users[id];

                switch (key.ToLower())
                {
                    case "name":
                        user.Name = value;
                        break;
                    case "email":
                        user.Email = value;
                        break;
                    case "contact":
                        user.Contact = value;
                        break;
                    default:
                        Console.WriteLine("No such key is present");
                        return;
                }
                UserAction.Invoke($"User {user.Id} data has been updated");
            }
        }


    }
}
