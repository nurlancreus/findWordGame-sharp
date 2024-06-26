﻿// start again 
bool playGame = true;
void StartAgain()
{
    Console.WriteLine("Try again?");
    var userInput = Console.ReadKey();
    Console.Clear();

    if (userInput.Key == ConsoleKey.Enter)
    {
        Console.WriteLine("You Start The Game Again!");
        InitGame();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("EXIT GAME");
        playGame = false;
        InitGame();
    }
};

// init game
void InitGame()
{
    if (!playGame) return;

    string hiddenWord = "Front-End";
    int attempts = 5;
    bool correctAnswer = false;

    Console.WriteLine("not \"Back-End\" but *****?");

    while (!(correctAnswer || attempts == 0))
    {
        try
        {
            string userAnswer = Console.ReadLine().ToLower();

            if (userAnswer == null)
                throw new InvalidOperationException("Null input received."); // Throw exception if null input is received

            if (userAnswer == hiddenWord.ToLower())
            {
                correctAnswer = true;
                Console.WriteLine("Correct Answer! YEHOOOOO");
                StartAgain();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Wrong Answer! Please try again. You got {--attempts}");
            }

            if (attempts == 0)
            {
                Console.Clear();
                Console.WriteLine($"You LOST! The word was \"{hiddenWord}\"");
                StartAgain();
            }

        }
        catch (InvalidOperationException e)
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter a string value.");
            StartAgain();
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.WriteLine("An error occurred: " + e.Message);
            StartAgain();
        }

    };
}

if(playGame) InitGame();