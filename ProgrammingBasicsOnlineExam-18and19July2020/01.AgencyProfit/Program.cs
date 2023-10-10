string companyName = Console.ReadLine();
double ticketsOld = int.Parse(Console.ReadLine());
double ticketsChild = int.Parse(Console.ReadLine());
double priceTicketsOld = double.Parse(Console.ReadLine());
double tax= double.Parse(Console.ReadLine());


double priceTiketsChild = priceTicketsOld -(priceTicketsOld *0.7);

double oldPrice = priceTicketsOld + 40;
double childPrice = priceTiketsChild + 40;
double finalPirce = (oldPrice * ticketsOld) + (childPrice * ticketsChild);
double finalProfit = finalPirce * 0.2;

Console.WriteLine($"The profit of your agency from {companyName} tickets is {finalProfit:F2} lv.");