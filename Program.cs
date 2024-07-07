Console.WriteLine("Welcome to number guessing game");
Console.WriteLine("Enter a number between 1 and 100 ");

bool isCorrectNumber  = false;
Random random = new Random();
int playerGuess;
int randomNumber = random.Next(1, 100);

GameFunction();
PlayAgain();

void PlayAgain()
{
    Console.WriteLine("PLAY AGAIN.....[Y/N]");
    var input = Console.ReadLine();

    if (input == "Y" || input == "y")
    {
        randomNumber = random.Next(1, 100);
        GameFunction();
        Console.ReadKey();
    }
    else if (input == "N" || input == "n")
    {
        isCorrectNumber = true;
        Console.WriteLine("THANK YOU");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("INVALID INPUT. PLEASE TRY AGAIN");
        PlayAgain();
    }

}

void GameFunction()
{
    do
    {
        Console.WriteLine(randomNumber);
        Console.Write("ENTER YOUR GUESS HERE >>>>> ");
        var input = Console.ReadLine();

        var isNumaric = int.TryParse(input, out playerGuess);
        //Console.WriteLine(isNumaric + " " + playerGuess);

        if (isNumaric)
        {
            if (playerGuess < 1 || playerGuess > 100)
            {
                Console.WriteLine("Invalid Guess");
            }
            else
            {
                Console.WriteLine("valid guess");
                CheckPlayerGuess();
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
    while (!isCorrectNumber);
}

void CheckPlayerGuess()
{
    if (playerGuess > randomNumber)
    {
        Console.WriteLine("your guess is too high\n");
    }
    else if (playerGuess < randomNumber) 
    {
        Console.WriteLine("your guess is too low\n");
    }
    else if (playerGuess == randomNumber)
    {
        Console.WriteLine("Congratulations! Your guess is correct ");
        isCorrectNumber = true;
    }
}