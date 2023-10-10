

string name = Console.ReadLine();

int grade = 1;
double sum = 0;
int classOver = 0;

while (grade <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());
    if (currentGrade < 4)
    {
        classOver++;
        if (classOver < 2)
        {
            continue;
        }
        else
        {
            Console.WriteLine($"{name} has been excluded at {grade} grade");
            break;
        }
    }
    grade++;
    sum+= currentGrade;
}

if (grade >= 12)
{

    double avg = sum / 12;
    Console.WriteLine($"{name} graduated. Average grade: {avg:F2}");
}


