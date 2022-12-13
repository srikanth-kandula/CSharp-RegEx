using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Devices
    {
        private string[] availableDevices = new string[] {
            "MCRW-01-UsbSmartDipReader",
            "MCRW-01-USBContactlessReader2",
            "DPM_-01-USBDPM",
            "DPM_-01-USBSignatureScanner"
        };

        public string findMatchingDevice(string value) {
            string pattern = value.Replace("*", ".*").Replace("?", "[a-zA-Z_-]").Replace("#", "[0-9]").Replace("!", "^") + "$";

            //if (!pattern.EndsWith("]"))
            //    pattern = pattern + "$";

            string matchingDevice = "No matching device!";

            foreach (string device in availableDevices)
            {
                try
                {
                    if (Regex.IsMatch(device, pattern))
                    {
                        matchingDevice = device;
                        break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Entered an invalid expression");
                }

            }

            return matchingDevice;
        }

        public string findMatchingDevice1(string value) {
            string pattern = replaceAsterisks(value);
            pattern = replaceHashtag(pattern);
            pattern = replaceQuestionMarks(pattern);
            pattern = replaceExclamationMark(pattern);
            //pattern = checkEndPattern(pattern);

            pattern = pattern + "$";

            string temp = Regex.Escape(value);
            Console.WriteLine($"temp = ${temp}");

            string matchingDevice = "No matching device";

            foreach (string device in availableDevices) {
                if (Regex.IsMatch(device, pattern)) {
                    matchingDevice = device;
                    break;
                }
            }

            return matchingDevice;
        }

        private string replaceAsterisks(string value)
        {
            string pattern = value.Replace("*", "[a-zA-Z0-9_-]");
            return pattern;
        }

        private string replaceQuestionMarks(string value) {
            string pattern = value.Replace("?", "[a-zA-Z_-]");
            return pattern;
        }

        private string replaceHashtag(string value)
        {
            string pattern = value.Replace("#", "[0-9]");
            return pattern;
        }

        private string replaceExclamationMark(string value) {
            string pattern = value.Replace("!", "^");
            return pattern;
        }

        private string checkEndPattern(string value) {
            if (!value.EndsWith("]")) {
                value = value + "$";
            }
            return value;
        }


        //private string replaceEnclosedChars() {
        //    //https://learn.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.escape?view=netframework-4.8#examples
        //    return " ";
        //}
    }
}
