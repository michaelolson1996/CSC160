using System;
using System.Text.RegularExpressions;

namespace Library
{
    public class CliLib
    {
        public int GetConsoleInt(string message, int min, int max)
        {
            bool responding = true;
            int number = 0;
            while (responding)
            {
                Console.WriteLine(message);

                if (!Int32.TryParse(Console.ReadLine(), out number) || number < min || number > max)
                    Console.WriteLine($"Please enter a valid input, max={max}, min={min}");
                else
                    responding = false;
            }

            return number;
        }

        public bool GetConsoleBool(string message)
        {
            bool responding = true;
            bool response = false;

            while (responding)
            {
                Console.WriteLine(message);

                if (!bool.TryParse(Console.ReadLine(), out response))
                    Console.WriteLine("Please enter a valid input");
                else
                    responding = false;
            }

            return response;
        }

        public char GetConsoleChar(string message)
        {
            char userChar = 'a';
            bool responding = true;

            while (responding)
            {
                Console.WriteLine(message);

                if (!char.TryParse(Console.ReadLine(), out userChar) || !Regex.IsMatch(userChar.ToString(), "[a-zA-Z]"))
                    Console.WriteLine("Please enter a valid input");
                else
                    responding = false;
            }

            return userChar;
        }

        public string GetConsoleString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public int GetConsoleMenu(string[] items)
        {
            int count;
            bool responding = true;
            int number = 0;
            while (responding)
            {
                count = 1;
                foreach (string item in items)
                {
                    Console.WriteLine($"{count} - {item}");
                    count++;
                }
                Console.Write("Enter Response : ");
                string response = Console.ReadLine();

                if (!Int32.TryParse(response, out number) && number > 0 && number < 5)
                    Console.WriteLine("Please enter a valid input");
                else
                    return number;
            }
            return number;
        }
    }
}
