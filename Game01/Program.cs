// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// start again 
static void StartAgain()
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
    }
};

// Find word Game
static void InitGame()
{
    string hiddenWord = "Front-End";
    int attempts = 5;

    bool correctAnswer = false;

    Console.WriteLine("not \"Back-End\" but *****?");
    do
    {
        string userAnswer = Console.ReadLine().ToLower();

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
            Console.WriteLine($"You LOST! The word was {hiddenWord}");
            StartAgain();
        }
    } while (!correctAnswer || attempts == 0);
}

InitGame();