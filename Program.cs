using UserService;

public class Program
{
    public static void Main(string[] args)
    {
        UserManagement usrMngmnt = new UserManagement();

        usrMngmnt.UserAction += NotificationService.Notify;

        User usr1 = new User { Id = 1, Name = "user1", Email = "abc@gmail.com", Contact = "12345" };
        User usr2 = new User { Id = 2, Name = "user2", Email = "abc@gmail.com", Contact = "122323" };
        usrMngmnt.AddUser(usr1);
        usrMngmnt.AddUser(usr2);
        usrMngmnt.RemoveUser(usr1.Id );
        usrMngmnt.UpdateUser(usr2.Id, "Name", "new");
    }
}