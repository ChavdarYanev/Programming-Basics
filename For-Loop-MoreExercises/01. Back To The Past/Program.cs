double startingMoney = double.Parse(Console.ReadLine());
double year = int.Parse(Console.ReadLine());
double ivanchoYears = 17;
double money = startingMoney;
for (int i = 1800; i <= year; i++)
{
    ivanchoYears++;
    if (i % 2 == 0)
    {
        money -= 12000;
    }
    else
    {
        money = money - (12000+(50 * ivanchoYears));
    }
}

if (startingMoney >= money && money>=0)
{
   
    Console.WriteLine($"Yes! He will live a carefree life and will have {money:F2} dollars left.");
}
else
{

    double finalMoney = Math.Abs(money);
    Console.WriteLine($"He will need {finalMoney:F2} dollars to survive.");
}

