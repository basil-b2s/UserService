using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public class UserManagement
    {
        private List<User> _users = new List<User>();

        public event Action<string, User> UserAction;

        public void AddUser(User user)
        {
           _users.Add(user);
            UserAction.Invoke("Added", user);
        }

       public void RemoveUser(int id)
        {
            var user = _users.Find(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
                UserAction.Invoke("Removed", user);
            }
            else
            {
                Console.WriteLine("No User Found");
            }
            
        }

        public void UpdateUser(int id, string key, string value)
        {
            var user = _users.Find(u => u.Id == id);
            if (user != null)
            {
      

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
                UserAction.Invoke("Updated", user);
            }
            else
            {
                Console.WriteLine("No User Found");
            }
        }


    }
}
