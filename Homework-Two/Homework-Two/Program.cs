// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//SWAP NUMBERS
Console.WriteLine("Enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Before swpping -- First number: {firstNumber} ; Second number: {secondNumber}");
int newNumber = firstNumber;
firstNumber = secondNumber;
secondNumber = newNumber;
Console.WriteLine($"After swapping -- First number: {firstNumber} ; Second number: {secondNumber}");



