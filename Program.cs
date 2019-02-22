// This is another (work in progress) project for IT 2040
// Cody Sloan
// 02/22/2019

using System;
using System.Collections.Generic;

namespace URLEncoder
{
    class Program
    {
        static string urlFormatString = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";

        static void Main(string[] args)
        {
            Console.WriteLine("URL Encoder");

            do
            {
                Console.Write("\nProject name: ");
                string projectName = GetUserInput();
                Console.Write("Activity name: ");
                string activityName = GetUserInput();

                Console.WriteLine(CreateURL(projectName, activityName));

                Console.Write("Would you like to do another? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }

        static string CreateURL(string projectName, string activityName)
        {
            // create the URL string and return it
        }

        static string GetUserInput()
        {
            // get valid input from the user
            Console.Write("\nProject name: ");
            string projectName = Console.ReadLine();
            Console.Write("Activity name: ");
            string activityName = Console.ReadLine();

            // disallow strings with control characters
            // IsValid() below is used to check if input is valid
        }

        static bool IsValid(string input)
        {
            // check if the string is valid and does not
            // contain control characters
            // if valid, return true
            // if not valid, return false

            foreach (char character in input.ToCharArray())
            {
                // check each character to see if it matches any of the not-allowed control characters
                if (character == 0x1F)
                {
                    return (true);
                }
                else
                {
                    return (false);
                }
            }

        }

        static string Encode(string value)
        {
            string encodedValue = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";
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