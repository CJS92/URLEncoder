// This is another project for IT 2040
// Code base was taken from the 'Help' module
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
        static string urlFormatString = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";

        static void Main(string[] args)
        {
            Console.WriteLine("URL Encoder");
           
            // gather user input
            do
            {
                Console.Write("\nProject name: ");
                string projectName = GetUserInput();
                Console.Write("Activity name: ");
                string activityName = GetUserInput();

                Console.WriteLine(CreateURL(projectName, activityName));

                Console.Write("\nWould you like to start over? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }

        // create URL
        static string CreateURL(string projectName, string activityName)
        {
            
                string value = "";
                Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", projectName, activityName);
                Console.ReadLine();
                return value;
           
        }

        // get input
        static string GetUserInput()
        {
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (IsValid(input)) return input;
                Console.Write("The input contains invalid characters. Enter again: ");
            } while (true);
        }

        // check input and determine if it is valid
        static bool IsValid(string input)
        {
            foreach (char character in input.ToCharArray())
            {
                // check each character to see if it matches any of the not-allowed control characters
                if (character >= 0x1F && character <= 0x7F)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;

        }

        // encode the input
        static string Encode(string value)
        {
            string encodedValue = "";
            foreach (char character in value.ToCharArray())
            {
                // build the encodedValue string by getting each character
                // in the original string and adding it to encodedValue if the original is ok
                // OR changing it to an encoded value and adding the encoded value to the string
                // if it is one of the values that needs to change
            }
            return encodedValue;
        }
    }
}

