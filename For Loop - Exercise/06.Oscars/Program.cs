string actorName = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int teachers = int.Parse(Console.ReadLine());

double sumPoints = points;
for (int i = 0; i < teachers; i++)
{
    string teacher = Console.ReadLine();
    double teacherPoint = double.Parse(Console.ReadLine());
    double finalPoints = (teacher.Length * teacherPoint) / 2;
    sumPoints += finalPoints;
    if (sumPoints > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {sumPoints:F1}!");
        return;
    }
}

    Console.WriteLine($"Sorry, {actorName} you need {1250.5-sumPoints:F1} more!");

