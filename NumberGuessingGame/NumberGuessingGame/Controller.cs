using System;

namespace NumberGuessingGame
{
    class Controller
    {

        View messenger = new View();

        public void StartGame(string[] args)
        {
            if (args.Length > 0)
                this.DetermineSound(args[0]);
        }

        private void DetermineSound(string arg)
        {
            if (arg.Equals("sound"))
            {
                Console.WriteLine("true");
            }
        }
    }
}
