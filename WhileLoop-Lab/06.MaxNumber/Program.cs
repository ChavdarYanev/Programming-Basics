string input = Console.ReadLine();

int max = int.MinValue; 
while (input != "Stop")
{
    int currentAmount = int.Parse(input);
    if (currentAmount > max)
    {
        max = currentAmount;
    }

    input = Console.ReadLine();
}
Console.WriteLine(max);
