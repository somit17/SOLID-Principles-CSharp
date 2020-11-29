using System;
public class User{
    void Login(string username,string password){
        System.Console.WriteLine("Login");
    }


    void Register(string username,string password){
         System.Console.WriteLine("Register");
    }

    
   
}
public class Log{
    void Logging(string logError){
        System.Console.WriteLine("Logging");
    }

}

public class Email{
     void SendEmail(string content){
         System.Console.WriteLine("Logging");
    }
}