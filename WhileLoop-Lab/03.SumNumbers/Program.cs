﻿int num = int.Parse(Console.ReadLine());
int sum = 0;

while (true)
{
    int numbers = int.Parse(Console.ReadLine());
    sum += numbers;
    if (sum >= num)
    {
        Console.WriteLine(sum);
        break;
    }
}
