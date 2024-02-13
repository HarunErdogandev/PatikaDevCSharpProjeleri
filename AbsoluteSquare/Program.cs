using System;

Console.WriteLine("Lütfen sayıları aralarında boşluk bırakarak girin:");
string input = Console.ReadLine();

string[] numbers = input.Split(' ');
int sumOfDifferences = 0;
int sumOfSquaredDifferences = 0;

foreach (string number in numbers)
{
    int n = int.Parse(number);
    int difference = Math.Abs(n - 67);

    if (n < 67)
    {
        sumOfDifferences += difference;
    }
    else
    {
        sumOfSquaredDifferences += difference * difference;
    }
}

if (sumOfDifferences > 0)
{
    Console.WriteLine("Output: " + sumOfDifferences);
}
else
{
    Console.WriteLine("Output: " + sumOfSquaredDifferences);
}