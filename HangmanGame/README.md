# Hangman Console Game

A classic game of Hangman implemented as a C# console application. Players try to guess a secret word letter by letter before running out of guesses. This project was developed as a learning exercise to practice C# fundamentals and console application development.

## Features

*   **Random Word Selection:** A secret word is randomly chosen from a predefined list for each new game.
*   **Interactive Gameplay:**
    *   Main menu to start a new game or exit.
    *   Players input letter guesses one at a time.
*   **Visual Feedback:**
    *   The secret word is displayed with underscores for unguessed letters (e.g., `_ _ T _ _`).
    *   The display updates as correct letters are guessed.
*   **Guess Tracking:**
    *   Keeps track of the number of incorrect guesses remaining (starts at 5).
    *   Displays letters that have already been guessed by the player.
*   **Input Validation:**
    *   Prompts the user again if they enter empty input.
    *   Ensures the guessed input is a valid letter (A-Z).
*   **Gameplay Rules:**
    *   Guessing a letter that has already been tried results in a penalty (loss of a guess).
    *   Letter guessing is case-insensitive.
*   **Win/Loss Conditions:**
    *   Player wins if they guess all letters in the secret word before running out of guesses.
    *   Player loses if they run out of guesses.
    *   The secret word is revealed at the end of the game (win or lose).
*   **Play Again:** Option to play another game after one finishes, without restarting the application.

## Technologies Used

*   C#
*   .NET Console Application

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

*   [.NET SDK](https://dotnet.microsoft.com/download) (Version 6.0 or newer recommended)
*   A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/) (Optional, but helpful for development)
*   Git (Optional, if you plan to clone and contribute or manage versions)

### Installation & Running

1.  **Clone the repository (if you've pushed it to a remote like GitHub):**
    ```
    git clone <your-repository-url>
    cd <project-directory-name>
    ```
    *(If you are working locally without a remote repository yet, you can skip this step and just navigate to your project folder.)*

2.  **Navigate to the project directory:**
    Open your terminal or command prompt and use the `cd` command to go into the root folder of the project (where the `.csproj` file is located).

3.  **Run the application:**
    Execute the following command in your terminal:
 
    ```
    dotnet run
 
    ```
    This will build and run the console application.

## How to Play

1.  Launch the application.
2.  You will be presented with a menu:
    *   Enter `1` for a "New Game".
    *   Enter `2` to "Exit".
3.  If you start a new game:
    *   The game will display the length of the secret word using underscores (e.g., `_ _ _ _ _`).
    *   You will see the number of guesses you have left.
    *   You will see a list of letters you've already guessed (initially empty).
4.  Enter a single letter when prompted and press Enter.
5.  The game will inform you if your guess is correct or incorrect:
    *   If correct, the letter(s) will be revealed in the word display.
    *   If incorrect, you will lose a guess.
    *   If you re-guess a letter you've already tried, you will lose a guess.
6.  Continue guessing letters until you either:
    *   Guess the entire word (You Win!).
    *   Run out of guesses (Game Over!).
7.  After a game ends, you will be returned to the main menu to play again or exit.

## Future Enhancements (Ideas)

*   Difficulty levels (affecting word length or number of guesses).
*   Word categories (e.g., Animals, Countries).
*   Loading words from an external text file.
*   A visual representation of the hangman figure.
*   Hint system.

---

Feel free to modify this README to better suit any specific details or future plans for your project!
