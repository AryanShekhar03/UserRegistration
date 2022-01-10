using System;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class UC4MobileFormat
    {
        public static string REGEX_MobileNo = "^[0-9]{1,3}[ ][6789][0-9]{9}$"; 

        public bool ValidateMobileNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, REGEX_MobileNo);
        }
    }
}