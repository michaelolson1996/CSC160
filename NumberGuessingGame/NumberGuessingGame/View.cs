using System;

namespace NumberGuessingGame
{
    class View
    {

        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

        // Basic Display Messages

        public void DisplayLoseMessage()
        {
            this.DisplayBlackBGYellowFG();
            Console.WriteLine("Unfortunately you have lost, good try!");
            this.ReturnDisplayToNormal();
        }

        public void DisplayNumberError()
        {
            this.DisplayRedBGWhiteFG();
            Console.WriteLine("The value provided is not valid, please provide a valid number");
            this.ReturnDisplayToNormal();
        }

        public void DisplayStringError()
        {
            this.DisplayRedBGWhiteFG();
            Console.WriteLine("The value provided is not valid, please try again");
            this.ReturnDisplayToNormal();
        }

        public void DisplayWelcomeMessage()
        {
            this.DisplayBlackBGCyanFG();
            Console.WriteLine("Welcome to the random number guessing game!");
            this.ReturnDisplayToNormal();
        }

        public void DisplayTooHighMessage()
        {
            this.DisplayBlackBGYellowFG();
            Console.WriteLine("Your guess was higher than the correct value");
            this.ReturnDisplayToNormal();
        }

        public void DisplayTooLowMessage()
        {
            this.DisplayBlackBGYellowFG();
            Console.WriteLine("Your guess was lower than the correct value");
            this.ReturnDisplayToNormal();
        }

        public void DisplayGoodbyeMessage()
        {
            this.DisplayBlackBGCyanFG();
            Console.WriteLine("Good Bye and thank you for playing!");
            this.ReturnDisplayToNormal();
        }

        // Display Messages containing input from user

        public void DisplayMaximumNumber(int maxnum)
        {
            this.DisplayBlackBGCyanFG();
            Console.WriteLine($"Please guess a number between 1 and {maxnum}");
            this.ReturnDisplayToNormal();
        }

        public void DisplayRemainingAttempts(int remainingnum)
        {
            this.DisplayBlackBGCyanFG();
            Console.WriteLine($"{remainingnum} attempts left");
            this.ReturnDisplayToNormal();
        }

        public void DisplayWinMessage(int winningnum)
        {
            this.DisplayBlackBGCyanFG();
            Console.WriteLine($"Congratulations! {winningnum} was the correct value!");
            this.ReturnDisplayToNormal();
        }

        public void DisplayNumberGuessError(int maximumnum)
        {
            this.DisplayRedBGWhiteFG();
            Console.WriteLine($"There was a problem verifying your number, please make sure it is greater than 0 and less than or equal to {maximumnum}");
            this.ReturnDisplayToNormal();
        }

        // Display Messages awaiting input from user

        public string RequestMaximumNumber()
        {
            this.DisplayWhiteBGBlueFG();
            Console.Write("Please Enter the max number to guess (Must be greater than 0): ");
            this.ReturnDisplayToNormal();
            return Console.ReadLine();
        }
        
        public string RequestGuessNumber()
        {
            this.DisplayWhiteBGBlueFG();
            Console.Write("Please enter your guess: ");
            this.ReturnDisplayToNormal();
            return Console.ReadLine();
        }

        public string PromptUserForSound()
        {
            this.DisplayWhiteBGBlueFG();
            Console.WriteLine("Argument found, but does not spell out sound. Would you like sound? [(y/yes)/(n/no)]: ");
            this.ReturnDisplayToNormal();
            return Console.ReadLine();
        }

        public string PromptUserForNewGameSound()
        {
            this.DisplayWhiteBGBlueFG();
            Console.WriteLine("Would you like sound? [(y/yes)/(n/no)]: ");
            this.ReturnDisplayToNormal();
            return Console.ReadLine();
        }

        public string PromptUserToPlayAgain()
        {
            this.DisplayWhiteBGBlueFG();
            Console.WriteLine("Would you like to play again? [(y/yes)/(n/no)]: ");
            this.ReturnDisplayToNormal();
            return Console.ReadLine();
        }

        private void DisplayRedBGWhiteFG()
        {
            Console.BackgroundColor = colors[12];
            Console.ForegroundColor = colors[15];
        }

        private void DisplayBlackBGYellowFG()
        {
            Console.BackgroundColor = colors[0];
            Console.ForegroundColor = colors[14];
        }

        private void DisplayWhiteBGBlueFG()
        {
            Console.BackgroundColor = colors[15];
            Console.ForegroundColor = colors[9];
        }

        private void DisplayBlackBGCyanFG()
        {
            Console.BackgroundColor = colors[0];
            Console.ForegroundColor = colors[11];
        }

        public void ReturnDisplayToNormal()
        {
            Console.BackgroundColor = colors[0];
            Console.ForegroundColor = colors[15];
        }
    }
}
