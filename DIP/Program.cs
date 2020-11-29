using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {

            var user= new User("TOm",new ConsoleNotification());
            user.ChangeUserName("Josh");
            Console.WriteLine("Hello World!");
        }
    }
}
