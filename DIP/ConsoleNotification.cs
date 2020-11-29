namespace DIP
{
    public interface INotificationService
    {
         void NotifyUsernameChanged(User user);
    }
    public class ConsoleNotification:INotificationService
    {
        void NotifyUsernameChanged(User user){
            System.Console.WriteLine($"Username has been changed to {user.username}");
        }
    }
}