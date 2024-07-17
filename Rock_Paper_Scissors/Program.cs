string playerInput;
string computerInput;
int randomInt;

bool playAgain = true;


while (playAgain)
{
    int scorePlayer = 0;
    int scoreComputer = 0;

    while (scorePlayer < 3 && scoreComputer < 3)
    {
        Console.WriteLine("Choose between Rock, Paper and Scissors");
        playerInput = Console.ReadLine().ToUpper();

        Random r = new Random();
        randomInt = r.Next(1, 4);

        switch (randomInt)
        {
            case 1:
                computerInput = "ROCK";
                Console.WriteLine("Computer chose Rock");
                if (playerInput == "ROCK")
                {
                    Console.WriteLine("DRAW!!\n\n");
                }
                else if (playerInput == "PAPER")
                {
                    Console.WriteLine("PLAYER WINS!!\n\n");
                    scorePlayer++;
                }
                else if (playerInput == "SCISSORS")
                {
                    Console.WriteLine("COMPUTER WINS!!\n\n");
                    scoreComputer++;
                }
                break;
            case 2:
                computerInput = "PAPER";
                Console.WriteLine("Computer chose Paper");
                if (playerInput == "ROCK")
                {
                    Console.WriteLine("COMPUTER WINS!!\n\n");
                    scoreComputer++;
                }
                else if (playerInput == "PAPER")
                {
                    Console.WriteLine("DRAW!!\n\n");
                }
                else if (playerInput == "SCISSORS")
                {
                    Console.WriteLine("PLAYER WINS!!\n\n");
                    scorePlayer++;
                }
                break;
            case 3:
                computerInput = "SCISSORS";
                Console.WriteLine("Computer chose Scissors");
                if (playerInput == "ROCK")
                {
                    Console.WriteLine("PLAYER WINS!!\n\n");
                    scorePlayer++;
                }
                else if (playerInput == "PAPER")
                {
                    Console.WriteLine("COMPUTER WINS!!\n\n");
                    scoreComputer++;
                }
                else if (playerInput == "SCISSORS")
                {
                    Console.WriteLine("DRAW!!\n\n");
                }
                break;
            default:
                Console.WriteLine("Invalid entry!");
                break;
        }

        Console.WriteLine("\n\nSCORES: \tPLAYER:\t{0}:\tCOMPUTER:\t{1}", scorePlayer, scoreComputer);

    }

    if (scorePlayer == 3)
    {
        Console.WriteLine("Player WON!");
    }
    else if (scoreComputer == 3)
    {
        Console.WriteLine("Computer WON!");
    }
    else
    {

    }

    Console.WriteLine("Do you want to play again?(y/n)");
    string loop = Console.ReadLine();
    if (loop == "y")
    {
        playAgain = true;
        Console.Clear();
    }
    else if (loop == "n")
    {
        playAgain = false;
    }
    else
    {

    }

}

