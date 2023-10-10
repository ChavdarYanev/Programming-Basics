double groupNumber = int.Parse(Console.ReadLine());

double counterMusala = 0;
double counterMonblan = 0;
double counterKilimandjaro = 0;
double counterK2 = 0;
double counterEverest = 0;
double peopleSum = 0;


for (int i = 1; i <= groupNumber; i++)
{
    double people = int.Parse(Console.ReadLine());
    peopleSum+= people;

    if (people <= 5)
    {
        counterMusala += people;
    }
    else if (people > 5 && people <= 12)
    {
        counterMonblan += people;
    }
    else if (people > 12 && people <= 25)
    {
        counterKilimandjaro += people;
    }
    else if (people > 25 && people <= 40)
    {
        counterK2 += people;
    }
    else
    {
        counterEverest += people;
    }
}


double musala = (counterMusala / peopleSum) * 100;
double monblan = (counterMonblan / peopleSum) * 100;
double kilimandjaro = (counterKilimandjaro / peopleSum) * 100;
double k2 = (counterK2 / peopleSum) * 100;
double everest = (counterEverest / peopleSum) * 100;

Console.WriteLine($"{musala:F2}%");
Console.WriteLine($"{monblan:F2}%");
Console.WriteLine($"{kilimandjaro:F2}%");
Console.WriteLine($"{k2:F2}%");
Console.WriteLine($"{everest:F2}%");


