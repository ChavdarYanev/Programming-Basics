int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int size = a * b * c;
int sum = 0;

string input = Console.ReadLine();

while (input != "Done")
{
    sum += int.Parse(input);

    if (sum >= size)
    {
        Console.WriteLine($"No more free space! You need {sum-size} Cubic meters more.");
        break;
    }
    input = Console.ReadLine();

    if (input == "Done")

    {
        int left = size - sum;
        Console.WriteLine($"{left} Cubic meters left.");
    }

}

