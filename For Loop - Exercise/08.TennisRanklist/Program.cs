int tournamentsNumber = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());



double points = 0;
double winnerCounter = 0;

for (int i = 0; i < tournamentsNumber; i++)
{
    string tournamentPlace = Console.ReadLine();
    if (tournamentPlace == "W")
    {
        winnerCounter ++;
        points += 2000;
    }
    else if (tournamentPlace == "F")
    {
        points += 1200;
    }
    else
    {
        points += 720;
    }
}

double finalPoints = startingPoints + points;
double avaragePoints = Math.Floor((points / tournamentsNumber)) ;
double tournamentsWin = (winnerCounter / tournamentsNumber) * 100;

Console.WriteLine($"Final points: {finalPoints}");
Console.WriteLine($"Average points: {avaragePoints}");
Console.WriteLine($"{tournamentsWin:F2}%");
