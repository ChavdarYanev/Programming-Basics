using System.ComponentModel.Design;

double budget = double.Parse(Console.ReadLine());
string bilets = Console.ReadLine();
double people = double.Parse(Console.ReadLine());

double ticketPrice = 0.00;

if (bilets == "VIP")
{
     ticketPrice = 499.99;
}
else
{
    ticketPrice = 249.99;
}

if (people >= 1 && people <= 4)
{
    budget = budget - (budget * 0.75);
}
else if (people >= 5 && people <= 9)
{
    budget = budget - (budget * 0.60);
}
else if (people >= 10 && people <= 24)
{
    budget = budget - (budget * 0.50);
}
else if (people >= 25 && people <= 49)
{
    budget = budget - (budget * 0.40);
}
else
{
    budget = budget - (budget * 0.25);
}


double totalTicketsPrice = ticketPrice * people;

if (budget >= totalTicketsPrice)
{
    double moneyLeft = budget - totalTicketsPrice;
    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
}
else
{
    double neededMoney = totalTicketsPrice - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
}
