double badGrade = double.Parse(Console.ReadLine());
string lastProblem = string.Empty;
double sum = 0;
double counter = 0;
double badGradeCounter = 0;

while (true)
{
    string taskName = Console.ReadLine();
    
    if (taskName == "Enough")
    {
        double avg = sum / counter;
        Console.WriteLine($"Average score: {avg:F2}");
        Console.WriteLine($"Number of problems: {counter}");
        Console.WriteLine($"Last problem: {lastProblem}");
        break;

    }
    counter++;
    lastProblem = taskName;
    double grade = double.Parse(Console.ReadLine());
    if (grade <= 4)
    {
        badGradeCounter++;
        if (badGradeCounter == badGrade)
        {
            Console.WriteLine($"You need a break, {badGradeCounter} poor grades.");
            break;
        }
    }
    sum += grade;

}
