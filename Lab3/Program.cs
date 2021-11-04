using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {

                string pattern = RealName();
                Regex regex = new Regex(pattern);
                Console.WriteLine("What is your first and last name?");
                string input = Console.ReadLine();
                bool isMatch = regex.IsMatch(input);
                if (isMatch == false)
                {
                    Console.WriteLine("Sorry my broski, but it's gotta be your first " +
                        "and last name with the first letters capatilized.");
                }
                else
                {
                    repeat = false;
                }
            }
            while (repeat == true);
            repeat = true;
            do
            {
                string pattern = ValidEmail();
                Regex regex = new Regex(pattern);
                Console.WriteLine("Please tell me your email, promise it's a real" +
                    " prince sending you money this time.");
                string input = Console.ReadLine();
                bool isMatch = regex.IsMatch(input);
                if (isMatch == false)
                {
                    Console.WriteLine("No seriously! No scam! It's just gotta be an email " +
                        " like turtlesarecool@boot.com");
                }
                else
                {
                    repeat = false;
                }
            }
            while (repeat == true);
            repeat = true;
            do
            {
                string pattern = PhoneNumber();
                Regex regex = new Regex(pattern);
                Console.WriteLine("Ok, ok I swear this on my CPU, I need your phone number and I won't " +
                    "spam call you about auto insurance.");
                string input = Console.ReadLine();
                bool isMatch = regex.IsMatch(input);
                if (isMatch == false)
                {
                    Console.WriteLine("Make sure to type in dashes it has to be something like" +
                        " xxx-xxx-xxxx!");
                }
                else
                {
                    repeat = false;
                }
            }
            while (repeat == true);
            repeat = true;
            do
            {
                string pattern = TheDate();
                Regex regex = new Regex(pattern);
                Console.WriteLine("One Last thing, could you type out the date for me please?");
                string input = Console.ReadLine();
                bool isMatch = regex.IsMatch(input);
                if (isMatch == false)
                {
                    Console.WriteLine("Bruh...it's gotta look like" +
                        " 00/00/0000");
                }
                else
                {
                    repeat = false;
                }
            }
            while (repeat == true);
        }
        public static string RealName()
        {
            string realPattern = "[A-Z][a-zA-Z]{2,30} [A-Z][a-zA-Z]{2,30}";
            return realPattern;
        }
        public static string ValidEmail()
        {
            string validEmail = "[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}.[a-zA-Z0-9]{2,3}";
            return validEmail;
        }
        public static string PhoneNumber()
        {
            string phoneNumber = "[0-9]{3}-[0-9]{3}-[0-9]{4}";
            return phoneNumber;
        }
        public static string TheDate()
        {
           string theDate = @"[0-9]{2}\/[0-9]{2}\/[0-9]{4}";
            return theDate;
        }
    }
}
