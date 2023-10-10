using System.Diagnostics.Metrics;

int age = int.Parse(Console.ReadLine());
double washingMachine = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

double sum = 0;
double toyCounter = 0;


for (int i = 1; i <= age; i++)
{
   if (i % 2 == 0)
    {
    
        sum += (i*5)-1;

    }
    else
    {
        toyCounter += 1;
    }
}



double finalSum = sum + (toyCounter * toyPrice);




if (finalSum >= washingMachine)
{
    double diff = finalSum - washingMachine;
    Console.WriteLine($"Yes! {diff:F2}");
}
else
{
    double diff = washingMachine - finalSum;
    Console.WriteLine($"No! {diff:F2}");
}
