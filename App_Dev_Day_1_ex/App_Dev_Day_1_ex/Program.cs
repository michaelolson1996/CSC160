using System;
using MyHailStone;

namespace App_Dev_Day_1_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            if (args.Length != 1)
            {
                throw new Exception("you suck, give me one arg");
            }

            int number;

            if (Int32.TryParse(args[0], out number) && number >= 1)
            {
                var hail = new HailStone(number);
                hail.PrintSequence();
            }



            // ref => pass the reference / address of the var
            // out => initialize var
            // in => 
        }
    }
}