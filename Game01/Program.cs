// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// start again 
bool playGame = true;
static void StartAgain(ref bool playGame)
{
    Console.WriteLine("Try again?");
    var userInput = Console.ReadKey();
    Console.Clear();

    if (userInput.Key == ConsoleKey.Enter)
    {
        Console.WriteLine("You Start The Game Again!");
        InitGame(playGame);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("EXIT GAME");
        playGame = false;
        InitGame(playGame);
    }
};

// Find word Game
static void InitGame(bool playGame)
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
                StartAgain(ref playGame);
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
                StartAgain(ref playGame);
            }

        }
        catch (InvalidOperationException e)
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter a string value.");
            StartAgain(ref playGame);
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.WriteLine("An error occurred: " + e.Message);
            StartAgain(ref playGame);
        }

    };
}

if(playGame) InitGame(playGame);