using System;
using Library;

namespace ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool quit = false;
            string[] menuOptions = new string[] { "Open", "Save", "Print", "Quit" };
            Form myForm = new Form();
            CliLib myLib = new CliLib();

            while (!quit)
            {
                myForm.Age = myLib.GetConsoleInt("What is your age?", 0, 110);
                myForm.AreaCode = myLib.GetConsoleInt("What is your area code?", 0, 999);
                myForm.ZipCode = myLib.GetConsoleInt("What is your zip code?", 0, 99999);
                myForm.Number = myLib.GetConsoleInt("What is your favorite Number?", 0, 999999999);
                myForm.FirstInitial = myLib.GetConsoleChar("What is your first initial?");
                myForm.LastName = myLib.GetConsoleString("What is your last name?");
                myForm.IsAwesome = myLib.GetConsoleBool("Are you awesome? [true/false]");
                int option = myLib.GetConsoleMenu(menuOptions);

                switch (option)
                {
                    case 1:
                    case 2:
                        {
                            continue;
                        }
                    case 3:
                        {
                            myForm.Print();
                            break;
                        }
                    case 4:
                        {
                            quit = true;
                            break;
                        }
                }
            }
        }
    }

    class Form
    {
        public int Age { get; set; }
        public int AreaCode { get; set; }
        public int ZipCode { get; set; }
        public int Number { get; set; }
        public char FirstInitial { get; set; }
        public bool IsAwesome { get; set; }
        public string LastName { get; set; }

        public void Print()
        {
            Console.WriteLine
                (
                $"Age : {this.Age}\n" +
                $"Area Code : {this.AreaCode}\n" +
                $"Zip Code : {this.ZipCode}\n" +
                $"Number : {this.Number}\n" +
                $"First Initial : {this.FirstInitial}\n" +
                $"Is Awesome : {this.IsAwesome}\n" +
                $"Last Name : {this.LastName}"
                );
        }
    }
}
