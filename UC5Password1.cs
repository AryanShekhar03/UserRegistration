using System;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class UC5Password1
    {
        public static string REGEX_Password1 = "^[A-Z a-z]{8,}$" ; 

        public bool ValidatePassword1(string password)
        {
            return Regex.IsMatch(password, REGEX_Password1);
        }
    }
}