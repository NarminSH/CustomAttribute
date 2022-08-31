using System;

public class User
{
    public string Name { get; set; }
    [IsValidEmail]
    public string Email { get; set; }

    public string Password { get; set; }
}


