using System.Collections.Generic;

Console.WriteLine("Welcome to HangManGame");

int gameOptions = 0;
bool isExit = false;

Console.WriteLine();

do
{
    bool isWin = false;
    bool isLost = false;
    bool[] hasGuessedLetter = new bool[26];
   

    string[] arrayWords = { "Ram", "Sita", "Lakshman", "Tom", "Henrey" };
    
    Console.WriteLine(" 1. New Game \n 2. Exit\n");

    gameOptions = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    switch (gameOptions)
    {
        case 1:

            Random rand = new Random();

            int guessesLeft = 5;
            int returnIndex = rand.Next(0, arrayWords.Length);
            string seceretWordOriginalCase = arrayWords[returnIndex];

            string secretWord = seceretWordOriginalCase.ToUpper();

            char[] secretWordCharArray = secretWord.ToCharArray();
            char[] displayChars = new char[secretWordCharArray.Length];

            for (int i = 0; i < displayChars.Length; i++)
            {
                displayChars[i] = '_';
       
            }

            while (!isWin && !isLost)
            {

                Console.WriteLine();

                Console.Write("Current word: "); 
                foreach (char c_display in displayChars)
                {
                    Console.Write(c_display + " ");
                }
                Console.WriteLine();

                Console.WriteLine($"\nYou have {guessesLeft} guesses left.");

                Console.Write("\nGuessed Letters: ");

                for (int i = 0; i < hasGuessedLetter.Length; i++)
                {
                    if (hasGuessedLetter[i])
                    {
                        Console.Write((char)('A' + i) + " ");
                    }
                }

                Console.WriteLine();


                Console.WriteLine("\nGuess the Letter.");

                string userInput = Console.ReadLine();
                bool isValidRetry = false;

                if (string.IsNullOrEmpty(userInput))
                {
                    while (!isValidRetry)
                    {
                        Console.WriteLine("Please Enter a character:");

                        userInput = Console.ReadLine();

                        if (!string.IsNullOrEmpty(userInput))
                        {
                            isValidRetry = true;
                        }
                    }
                }

                char guessedLetter = userInput.Trim().ToUpper()[0];

                if (!char.IsLetter(guessedLetter))
                {
                    Console.WriteLine("Please Enter a Valid Character A-Z:");
                    continue;
                }


              
                int index = guessedLetter - 'A';

                if (hasGuessedLetter[index])
                {
                    Console.Write($"\nYou already guessed this letter {guessedLetter}.");
                    guessesLeft--;
                    if (guessesLeft <= 0) { 
                    isLost = true;
                        Console.WriteLine("Out of attempts! Game Finished\n");
                    }
                    continue;
                }
                else
                {
                    hasGuessedLetter[index] = true;
                }

                bool isWonInRound = false;

                for (int i = 0; i < secretWordCharArray.Length; i++)
                {
                    if (guessedLetter == secretWordCharArray[i])
                    {
                        displayChars[i] = guessedLetter;
                        isWonInRound = true;
                    }
                }

                if (isWonInRound)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("You have guessed correct letter!.");
                }

                Console.WriteLine();

                string result = new string(displayChars);

                if (result.Equals(secretWord))
                {
                    Console.Write("You Won! ");
                    Console.WriteLine("The word was: " + secretWord + "\n");
                    isWin = true;
           
                }
                else if (!isWonInRound)
                {
                    {
                        guessesLeft--;
                        Console.WriteLine($"\nSorry, '{guessedLetter}' is not in the word.");

                        if (guessesLeft <= 0)
                        {
                            Console.WriteLine("Out of guesses! Game Over.");
                            Console.WriteLine("The word was: " + secretWord + "\n");
                            isLost = true;
                        }
                    }
                }
            }
            break;

        case 2:

            isExit = true;
            Console.WriteLine("Thank you");
            break;
    }
} while (!isExit);
