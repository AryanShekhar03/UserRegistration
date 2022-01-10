using System;
using System.Text.RegularExpressions;



namespace UserRegistration
{
    public class UC3CheckEmail
    {
        public static string REGEX_EMail = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$"; 

        public bool ValidateEMail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMail);
        }
    }
}