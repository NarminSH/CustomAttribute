using System;


public class Program
{
    static void Main(string[] args)
    {
        User user1 = new User();
        user1.Email = "qq";
        user1.Name = "nar";
        user1.Password = "11";
        Type userType = typeof(User);
        if (Validation.PropertyValueIsValid(userType, user1.Email, "Email", "kjscns"))
        {
            Console.WriteLine("kk");
        }
        Console.WriteLine(user1);

    }
}


