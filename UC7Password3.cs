using System;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class UC7Password3
    {
        public static string REGEX_Password3 = "^[A-Z]{1}[A-Z a-z]{7,}[0-9]{1,}$"; 

        public bool ValidatePassword3(string password)
        {
            return Regex.IsMatch(password, REGEX_Password3);
        }
    }
}