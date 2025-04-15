const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
Console.ForegroundColor = ConsoleColor.Blue;
string PlayerChoice = Console.ReadLine();

if (PlayerChoice == "r" || PlayerChoice == "rock")
{
    PlayerChoice = Rock;
}

else if (PlayerChoice == "p" || PlayerChoice == "paper")
{
    PlayerChoice = Paper;
}

else if (PlayerChoice == "s" || PlayerChoice == "scissors")
{
    PlayerChoice = Scissors;
}

else
{
    Console.WriteLine("Invalid Input. Try Again...");
    return;
}

Random random = new Random();
int computerrandomnumber = random.Next(1, 4);
string ComputerChoice = "";

switch (computerrandomnumber)
{
    case 1:
        ComputerChoice = Rock;
        break;

    case 2:
        ComputerChoice = Paper;
        break;

    case 3:
        ComputerChoice = Scissors;
        break;
}

Console.WriteLine($"The computer chose {ComputerChoice}.");

if ((PlayerChoice == Rock &&  ComputerChoice == Scissors) ||
    (PlayerChoice == Paper && ComputerChoice == Rock) || 
    (PlayerChoice == Scissors &&  ComputerChoice == Paper))
{
    Console.WriteLine("You win!");
    Console.ForegroundColor = ConsoleColor.Green;
}

else if ((PlayerChoice == Rock &&  ComputerChoice == Rock) ||
        (PlayerChoice == Paper && ComputerChoice == Paper) || 
        (PlayerChoice == Scissors &&  ComputerChoice == Scissors))
{
    Console.WriteLine("Draw.");
        Console.ForegroundColor = ConsoleColor.Yellow;
}

else
{
    Console.WriteLine("You loose!");
    Console.ForegroundColor = ConsoleColor.Red;
}
