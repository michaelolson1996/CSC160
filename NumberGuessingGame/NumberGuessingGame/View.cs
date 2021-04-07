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

        public void DisplayStringError()
        {
            Console.WriteLine("The value provided is not valid, please try again");
        }

        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the random number guessing game!");
        }

        public void DisplayTooHighMessage()
        {
            Console.WriteLine("Your guess was higher than the correct value");
        }

        public void DisplayTooLowMessage()
        {
            Console.WriteLine("Your guess was lower than the correct value");
        }

        public void DisplayGoodbyeMessage()
        {
            Console.WriteLine("Good Bye and thank you for playing!");
        }

        // Display Messages containing input from user

        public void DisplayMaximumNumber(int maxnum)
        {
            Console.WriteLine($"Please guess a number between 1 and {maxnum}");
        }

        public void DisplayRemainingAttempts(int remainingnum)
        {
            Console.WriteLine($"{remainingnum} attempts left");
        }

        public void DisplayWinMessage(int winningnum)
        {
            Console.WriteLine($"Congratulations! {winningnum} was the correct value!");
        }

        public void DisplayNumberGuessError(int maximumnum)
        {
            Console.WriteLine($"There was a problem verifying your number, please make sure it is greater than 0 and less than or equal to {maximumnum}");
        }

        // Display Messages awaiting input from user

        public string RequestMaximumNumber()
        {
            Console.Write("Please Enter the max number to guess (Must be greater than 0): ");
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
