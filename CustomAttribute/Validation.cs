using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

public static class Validation
{
    public static bool PropertyValueIsValid(Type t, string enteredValue,
        string elementName, string errorMessage)
    {
        PropertyInfo prop = t.GetProperty(elementName);
        Attribute[] attributes = prop.GetCustomAttributes().ToArray();
        foreach (Attribute attr in attributes)
        {
            switch (attr)
            {
                case IsValidEmail isemail:
                    if (!CheckEmail(isemail, enteredValue))
                    {
                        errorMessage = isemail.ErrorMessage;
                        errorMessage = string.Format(errorMessage, prop.Name, isemail.ValidEmail);
                        return false;

                    }
                    break;
            }

        }
        return true;
    }
    private static bool CheckEmail(IsValidEmail validEmail, string enteredValue)
    {
        if (Regex.IsMatch(enteredValue, validEmail.ValidEmail))
            return true;
        return false;
    }
}


