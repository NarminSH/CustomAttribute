using System;
using System.Text.RegularExpressions;


public class IsValidEmail : Attribute
{

    public string ErrorMessage { get; set; }
    public string ValidEmail { get; set; }

    public IsValidEmail()
    {

    }
    public IsValidEmail(string email)
    {

        SetProperties(email);
    }

    private void SetProperties(string email)
    {

        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(email);
        if (match.Success)
        {
            this.ValidEmail = email;
            Console.WriteLine("email was right");
        }
        else
        {
            ErrorMessage = "Invalid email address has been sent";
            Console.WriteLine(ErrorMessage);
        }
    }
}


