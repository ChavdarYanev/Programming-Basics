string country = Console.ReadLine();



while (country != "End")
{
    double budget = double.Parse(Console.ReadLine());

    double sum = 0;

   while (sum < budget)
   {
        double money = double.Parse(Console.ReadLine());
        sum += money;
   }

    Console.WriteLine($"Going to {country}!");
    country = Console.ReadLine();

}
