using System.Text.RegularExpressions;

namespace AktifInterview.Questions.Q7
{
    /*Extension methods allows to add new methods to a class.
     * Often used to add new methods to inaccessible classes*/
    public static class Question7StringExtensions
    {
        public static bool IsValidEmailFormat(this string email)
        {
            string emailFormatRegexPattern = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";
            return Regex.IsMatch(email, emailFormatRegexPattern, RegexOptions.IgnoreCase);
        }
    }
}
