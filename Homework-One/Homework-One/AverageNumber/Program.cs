// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter 4 numbers, to calculate their average"
    );
Console.WriteLine("Enter first Number");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second Number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third Number");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter forth Number");
int fourthNumber = Convert.ToInt32(Console.ReadLine());

decimal averageNumber = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4m;
Console.WriteLine($"The average of {firstNumber},{secondNumber},{thirdNumber},{fourthNumber} is {averageNumber}");