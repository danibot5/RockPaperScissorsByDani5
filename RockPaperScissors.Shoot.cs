const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
Console.ForegroundColor = ConsoleColor.Magenta;
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
    Console.ForegroundColor = ConsoleColor.Cyan;
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

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"The computer chose {ComputerChoice}.");

if ((PlayerChoice == Rock && ComputerChoice == Scissors) ||
    (PlayerChoice == Paper && ComputerChoice == Rock) ||
    (PlayerChoice == Scissors && ComputerChoice == Paper))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You win!");
}

else if ((PlayerChoice == Rock && ComputerChoice == Rock) ||
        (PlayerChoice == Paper && ComputerChoice == Paper) ||
        (PlayerChoice == Scissors && ComputerChoice == Scissors))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Draw.");
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You loose!");
}

Console.ForegroundColor = ConsoleColor.Black;
