using System.Diagnostics.Metrics;

string favBook = Console.ReadLine();
int bookCounter = 0;

while (true)
{
    string currentBook = Console.ReadLine();
    if (currentBook == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {bookCounter} books.");
        break;
    }
    if (currentBook != favBook )
    {
        bookCounter++;
    }
    if (currentBook == favBook)
    {
        Console.WriteLine($"You checked {bookCounter} books and found it.");
        break;
    }
    
}
