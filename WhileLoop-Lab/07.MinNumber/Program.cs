string input = Console.ReadLine();

int min = int.MaxValue;
while (input != "Stop")
{
    int currentAmount = int.Parse(input);
    if (currentAmount < min)
    {
        min = currentAmount;
    }

    input = Console.ReadLine();
}
Console.WriteLine(min);
