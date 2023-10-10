using System.Diagnostics.Metrics;

double neededMoneyForTrip = double.Parse(Console.ReadLine());
double startingMoney = double.Parse(Console.ReadLine());

int spendCounter = 0;
int dayCounter = 0;

while (true)
{
    string spendOrSave = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());

    dayCounter++;
    if (spendOrSave == "spend")
    {
        startingMoney -= money;
        if (startingMoney < 0)
        {
            startingMoney = 0;
        }
        spendCounter++;
        if (spendCounter == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{dayCounter}");
            break;
        }
    }
    else
    {
        startingMoney += money;
        spendCounter = 0;
    }

    
    if (startingMoney >= neededMoneyForTrip)
    {
        Console.WriteLine($"You saved the money for {dayCounter} days.");
        break;
    }

}
