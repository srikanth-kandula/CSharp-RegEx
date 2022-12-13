using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";

            //Console.WriteLine("Enter the search string");
            //value = Console.ReadLine();

            //var devices = new Devices();
            //string matchingDevice = devices.findMatchingDevice(value);
            //Console.WriteLine(matchingDevice);
            //Console.ReadLine();

            var devices = new Devices();
            while (true)
            {
                Console.WriteLine("Enter the search string");
                value = Console.ReadLine();
                if (value.Length > 1)
                {
                    string matchingDevice = devices.findMatchingDevice(value);
                    Console.WriteLine(matchingDevice);
                    //Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter a valid value");
                }

            }
        }


        /*

         */

    }
}
