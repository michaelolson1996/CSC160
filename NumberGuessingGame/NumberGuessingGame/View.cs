using System;

namespace NumberGuessingGame
{
    class View
    {

        // Basic Display Messages

        public void DisplayLoseMessage()
        {
            Console.WriteLine("Unfortunately you have lost, good try!");
        }

        public void DisplayNumberError()
        {
            Console.WriteLine("The value provided is not valid, please provide a valid number");
        }

        // Display Messages containing input from user

        public void DisplayMaximumNumber(int maxnum)
        {
            Console.WriteLine($"Please guess a number between 0 and {maxnum}");
        }

        public void DisplayRemainingAttempts(int remainingnum)
        {
            Console.WriteLine($"{remainingnum} attempts left");
        }

        public void DisplayWinMessage(int winningnum)
        {
            Console.WriteLine($"Congratulations! {winningnum} was the correct value!");
        }

        // Display Messages awaiting input from user

        public string RequestMaximumNumber()
        {
            Console.Write("Please Enter the max number to guess: ");
            return Console.ReadLine();
        }

        public string RequestGuessNumber()
        {
            Console.Write("Please enter your guess: ");
            return Console.ReadLine();
        }

        public string PromptUserToPlayAgain()
        {
            Console.WriteLine("Would you like to play again? [(y/yes)/(n/no)]: ");
            return Console.ReadLine();
        }
    }
}
