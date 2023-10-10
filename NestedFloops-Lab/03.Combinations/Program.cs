int number = int.Parse(Console.ReadLine());
int counter = 0;

for (int i = 0; i <= number; i++)
{
	for (int j = 0; j <= number; j++)
	{
		for (int g = 0; g <= number; g++)
		{
			if (i + j + g == number)
			{
				counter++;
			}
		}
	}

   
}

Console.WriteLine(counter);

