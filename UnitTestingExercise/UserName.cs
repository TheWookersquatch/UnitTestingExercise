using System.Text.RegularExpressions;

namespace UnitTestingExercise
{
    public class UserName
    {
        public UserName()
        {

        }

        public UserName(string username)
        {
            userName = username;
        }
        public string userName { get; set; }
        private static Regex sUserNameAllowedRegEx = new Regex(@"^[a-zA-Z]{1}[a-zA-Z0-9\._\-]{0,23}[^.-]$", RegexOptions.Compiled);
        private static Regex sUserNameIllegalEndingRegEx = new Regex(@"(\.|\-|\._|\-_)$", RegexOptions.Compiled);
        public  bool IsUserNameAllowed(string name)
        {
            if (string.IsNullOrEmpty(name)
                || !sUserNameAllowedRegEx.IsMatch(name)
                || sUserNameIllegalEndingRegEx.IsMatch(name))

            {
                return false;
            }
            return true;
        }
    }
}
