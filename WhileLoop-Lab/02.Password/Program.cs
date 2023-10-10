string name = Console.ReadLine();
string password = (Console.ReadLine());

while (true)
{
    string pass = Console.ReadLine();


    if (pass == password)
    {
        Console.WriteLine($"Welcome {name}!");
        break;
    }
}
