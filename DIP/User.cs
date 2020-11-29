namespace DIP
{
    public class User
    {
        private INotificationService _notificationService;
        public User(string username,INotificationService notificationService)
        {
            Username = username;
            _notificationService = notificationService;
        }

        public string Username{get;set;}

        public void ChangeUserName(string username){
            Username=username;
            _notificationService.NotifyUsernameChanged(Username);
        }
    }
}