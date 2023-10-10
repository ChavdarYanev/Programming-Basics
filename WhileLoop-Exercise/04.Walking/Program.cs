string steps = Console.ReadLine();
double sum = 0;
while (steps != "Going home")
{
    sum += int.Parse(steps);

    if (sum >= 10000)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{sum - 10000} steps over the goal!");
        break;
    }
    steps = Console.ReadLine();

   

}

if (steps == "Going home")
{
    sum += int.Parse(Console.ReadLine());
    if (sum >= 10000)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{sum - 10000} steps over the goal!");
        

    }
    else
    {
        Console.WriteLine($"{10000 - sum} more steps to reach goal.");
        
    }
}
