int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int allPieces = a * b;

string input = Console.ReadLine();

while (input!="STOP")
{
    allPieces -= int.Parse(input);
    
    if (allPieces <= 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(allPieces)} pieces more.");
        break;
    }

    input = Console.ReadLine();


}

if (input == "STOP")
{

    Console.WriteLine($"{allPieces} pieces are left.");
}
