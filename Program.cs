Console.WriteLine($"  **************************************\n   WELCOME TO THE NUMBER GUESSING GAME \n  **************************************");

bool isCorrectNumber  = false;
bool isPlaying = true;
Random random = new Random();
int playerGuess;
int guessCount = 1;
int randomNumber = random.Next(1, 100);

while (isPlaying)
{
    GameFunction();
    PlayAgain();
}

void GameFunction()
{
    do
    {
        Console.WriteLine("\n -- Enter a number between 1 and 100 -- \n        you have only 5 chances ");
        //Console.WriteLine(randomNumber);
        Console.Write("\n     ENTER YOUR GUESS HERE >>>>> ");
        var input = Console.ReadLine();

        var isNumaric = int.TryParse(input, out playerGuess);
        //Console.WriteLine(isNumaric + " " + playerGuess);

        if (isNumaric)
        {
            if (playerGuess < 1 || playerGuess > 100)
            {
                Console.WriteLine(" INVALID NUMBER. PLEASE ENTER A VAILD NUMBER\n");
            }
            else
            {
                //Console.WriteLine("valid guess");
                CheckPlayerGuess();
                guessCount++;

                if (guessCount > 5 && playerGuess != randomNumber)
                {
                    Console.WriteLine($"\n\t     YOU LOSE!\n       CORRRECT NUMBER IS : {randomNumber}");
                    isCorrectNumber = true;
                }
            }
        }
        else
        {
            Console.WriteLine(" INVALID INPUT. PLEASE ENTER A VALID INPUT\n");
        }
    }
    while (!isCorrectNumber);
    //Console.WriteLine("loop ended");
    //Console.WriteLine($" isCorrectNumber : {isCorrectNumber}");
    //Console.WriteLine($" isPlaying :  {isPlaying}");
}

void CheckPlayerGuess()
{
    if (playerGuess > randomNumber)
    {
        Console.WriteLine($" \n\t  -- Guess : {guessCount} --  \n\n        your guess is too high\n\n*****************************************");
    }
    else if (playerGuess < randomNumber)
    {
        Console.WriteLine($" \n\t  -- Guess : {guessCount} --  \n\n        your guess is too low\n\n*****************************************");
    }
    else if (playerGuess == randomNumber)
    {
        Console.WriteLine($" \n\t  -- Guess : {guessCount} -- \n\n CONGRATULATIONS! YOUR GUESS IS CORRECT \n\n*****************************************");
        isCorrectNumber = true;
    }
}

void PlayAgain()
{
    Console.Write("\n\tPLAY AGAIN [Y/N] .... ");
    var input = Console.ReadLine();

    if (input == "Y" || input == "y")
    {
        isCorrectNumber = false;
        guessCount = 1;
        randomNumber = random.Next(1, 100);
        //GameFunction();
    }
    else if (input == "N" || input == "n")
    {
        isPlaying = false;
        Console.WriteLine("\n\t   THANK YOU <3\n\t\t*\n      BY MALFUNCTION SOFTWARE");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("     INVALID INPUT. PLEASE TRY AGAIN");
        PlayAgain();
    }

}
