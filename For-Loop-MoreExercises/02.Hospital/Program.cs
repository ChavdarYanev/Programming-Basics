int days = int.Parse(Console.ReadLine());
int counterTreatedp = 0;
int counterUntreatedp = 0;

for (int i = 1; i <= days; i++)
{
    int people = int.Parse(Console.ReadLine());
    if (people >= 7)
    {
        counterTreatedp += people;
    }
    else
    {
        int diff = people - 7;
        counterUntreatedp += diff;
        counterTreatedp += 7;
    }
}

Console.WriteLine($"Treated patients: {counterTreatedp}.");
Console.WriteLine($"Untreated patients: {counterUntreatedp}.");
