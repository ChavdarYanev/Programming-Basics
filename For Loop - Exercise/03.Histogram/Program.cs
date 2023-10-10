int n = int.Parse(Console.ReadLine());
double counterUnder200 = 0;
double counter200to399 = 0;
double counter400to599 = 0;
double counter600to799 = 0;
double counterOver800 =0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < 200)
    {
        counterUnder200++;
    }
    else if (num >= 200 && num < 400)
    {
        counter200to399++;
    }
    else if (num >= 400 && num < 600)
    {
        counter400to599++;
    }
    else if (num >= 600 && num < 800)
    {
        counter600to799++;
    }
    else
    {
        counterOver800++;
    }
}


Console.WriteLine($"{(counterUnder200/n)*100:F2}%");
Console.WriteLine($"{(counter200to399 / n) * 100:F2}%");
Console.WriteLine($"{(counter400to599 / n) * 100:F2}%");
Console.WriteLine($"{(counter600to799 / n)* 100:F2}%");
Console.WriteLine($"{(counterOver800 / n) * 100:F2}%");
