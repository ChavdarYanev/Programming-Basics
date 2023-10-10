string money = Console.ReadLine();

double sum = 0;

while (money!="NoMoreMoney")
{

    double currentMoney = double.Parse(money);
    
    if (currentMoney < 0)
    {
        Console.WriteLine("Invalid operation!");
        
        break;
    }

    sum += currentMoney;

    Console.WriteLine($"Increase: {currentMoney:F2}");

    money = Console.ReadLine();
}

Console.WriteLine($"Total: {sum:F2}");
