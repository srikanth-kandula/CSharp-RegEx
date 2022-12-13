using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class ValidateString
    {
        private string pattern = @"[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$";
        private string endsWithPattern = "[a-zA-Z0-9][a-zA-Z0-9]ER$";
        private string startsWithPattern = "^edh";
        private string[] availableDevices = new string[] {
            "ABCD_somevalue",
            "somevalue_ABCD"
        };
        public void isValidRegex(string value)
        {
            //var regex = new Regex(pattern);
            string localValue = "ehflaroiaefafsER";

            bool result = Regex.IsMatch(localValue, endsWithPattern);
            Console.WriteLine(result);

            truncateStars("**ER");
            Console.ReadLine();
        }


        private void truncateStars(string str)
        {
            string temp = "asfas";
            temp = str.Replace("*", "[a-zA-Z0-9]");
            Console.WriteLine(temp);
            Console.ReadLine();
        }

        public static bool Like(String value, String mask, RegexOptions options = RegexOptions.Multiline & RegexOptions.IgnorePatternWhitespace)

        {

            String usepattern = "^" + Regex.Escape(mask).Replace("\\*", ".*").Replace("\\?", ".") + "$";

            return Regex.IsMatch(value, usepattern, options);

        }
    }
}
