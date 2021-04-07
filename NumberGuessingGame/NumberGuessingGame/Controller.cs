using System;
using System.Collections.Generic;

namespace NumberGuessingGame
{
    class Controller
    {
        View messenger = new View();
        List<Model> games = new List<Model>();
        Random rng = new Random();
        private bool isPlaying;

        public void StartGame(string[] args)
        {
            bool gameInSession = true;

            if (args.Length > 0)
                this.DetermineSoundFromCli(args[0]);
            else
                games.Add(new Model(false, 0));

            messenger.DisplayWelcomeMessage();

            while (gameInSession)
            {
                this.GetMaxNumFromUser();
                this.GetGuessesFromUser();
                this.requestAnotherGame();
                gameInSession = this.ProcessRequest();
            }
        }

        // TODO: Add function to verify user does not want to use sound
        // TODO: Implement sound when requested
        // TODO: Add color schemes
        private void DetermineSoundFromCli(string arg)
        {
            if (arg.Equals("sound"))
                games.Add(new Model(true, 0));
            else
                games.Add(new Model(false, 0)); 
        }


        private void GetMaxNumFromUser()
        {
            bool gettingMaxNum = true;
            int number;

            while (gettingMaxNum)
            {
                if (Int32.TryParse(messenger.RequestMaximumNumber(), out number) && number > 0)
                {
                    games[games.Count - 1].MaxNumber = number;
                    games[games.Count - 1].CorrectNumber = rng.Next(1, number);
                    gettingMaxNum = false;
                }                    
                else
                    messenger.DisplayNumberError();                   
            }
        }

        private void GetGuessesFromUser()
        {
            bool playerIsGuessing = true;
            while (playerIsGuessing)
            {
                int number;

                messenger.DisplayRemainingAttempts(games[games.Count - 1].TriesLeft);

                if (Int32.TryParse(messenger.RequestGuessNumber(), out number) && number > 0 && number < games[games.Count - 1].MaxNumber)
                {
                    if (number == games[games.Count - 1].CorrectNumber) {
                        messenger.DisplayWinMessage(number);
                        playerIsGuessing = false;
                    }
                    else
                    {
                        if (games[games.Count - 1].TriesLeft == 1)
                        {
                            messenger.DisplayLoseMessage();
                            playerIsGuessing = false;
                        }
                        else
                        {
                            if (number > games[games.Count - 1].CorrectNumber)
                                messenger.DisplayTooHighMessage();
                            else
                                messenger.DisplayTooLowMessage();

                            games[games.Count - 1].TriesLeft -= 1;
                        }
                    }
                }
                else
                {
                    messenger.DisplayNumberGuessError(games[games.Count - 1].MaxNumber);
                }
            }
        }

        private void requestAnotherGame()
        {
            bool gettingResponse = true;

            while (gettingResponse)
            {
                string response = messenger.PromptUserToPlayAgain();
                if (response.ToLower().Equals("y") || response.ToLower().Equals("yes"))
                {
                    this.isPlaying = true;
                    gettingResponse = false;
                }
                else if (response.ToLower().Equals("n") || response.ToLower().Equals("no"))
                {
                    this.isPlaying = false;
                    gettingResponse = false;
                }
                else
                {
                    messenger.DisplayStringError();
                }
            }
        }

        private bool ProcessRequest()
        {
            if (this.isPlaying)
            {
                Console.Clear();
                return true;
            }
            else
            {
                messenger.DisplayGoodbyeMessage();
                return false;
            }
        }
    }
}
