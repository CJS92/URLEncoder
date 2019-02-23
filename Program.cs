// This is another project for IT 2040
// Codebase was taken from the 'Help' module
// and modified to compile by me (Cody Sloan)
// 02/22/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        readonly static string urlFormatString = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";

        static void Main(string[] args)
        {
            Console.WriteLine("URL Encoder - Not Fully Functional");
            Console.WriteLine("-----------------------------------");

            // gather user input
            do
            {
                try
                {
                    Console.Write("\nProject name: ");
                    string projectName = GetUserInput();
                    Console.Write("Activity name: ");
                    string activityName = GetUserInput();

                    Console.WriteLine(CreateURL(projectName, activityName));
                }

                catch
                {
                    Console.WriteLine("The input contains invalid characters. Try again: ");
                }
                    Console.Write("\nWould you like to start over? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }

        // create URL
        static string CreateURL(string projectName, string activityName)
        {
            return String.Format(urlFormatString, projectName, activityName);
        }

        // get input
        static string GetUserInput()
        {
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (IsValid(input)) return input;
                Console.Write("The input contains invalid characters. Try again: ");
            } while (true);
        }

        // check input and determine if it is valid
        static bool IsValid(string input)
        {
            foreach (char character in input.ToCharArray())
            {
                // check each character to see if it matches any of the not-allowed control characters
                if ((character >= 0x00 && character <= 0x1F) || character == 0x7F)
                {
                    return false;
                }
            }
            return true;
        }

        // encode the input - NOT WORKING
        //static string Encode(string value)
        //{
        //    string encodedValue = "";
        //    foreach (char character in value.ToCharArray())
        //    {
        //        string characterString = character.ToString();

        //        if (character == '$')
        //        {
        //            encodedValue = "%24";
        //        }

        //        else if (character == ' ')
        //        {
        //            encodedValue = "%20";
        //        }

        //        else if (character == '&')
        //        {
        //            encodedValue = "%26";
        //        }

        //        else if (character == '+')
        //        {
        //            encodedValue = "%2B";
        //        }

        //        else if (character == ',')
        //        {
        //            encodedValue = "%2C";
        //        }

        //        else if (character == ':')
        //        {
        //            encodedValue = "%3A";
        //        }

        //        else if (character == ';')
        //        {
        //            encodedValue = "%3B";
        //        }

        //        else if (character == '=')
        //        {
        //            encodedValue = "%3D";
        //        }

        //        else if (character == '?')
        //        {
        //            encodedValue = "%3F";
        //        }

        //        else if (character == '@')
        //        {
        //            encodedValue = "%40";
        //        }
        //    }
        //    return encodedValue;
        //}
    }
}

