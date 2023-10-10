int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());
int counter = 0;
int secondCounter = 0;

for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j++)
    {
        counter++;
        if (i + j == magicNumber)
        {
            Console.WriteLine($"Combination N:{counter} ({i} + {j} = {i+j})");
            return;
        }
        else
        {
            secondCounter++;
        }
        

    }

    
}
Console.WriteLine($"{secondCounter} combinations - neither equals {magicNumber}");
