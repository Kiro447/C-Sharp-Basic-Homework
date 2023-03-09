// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter operator + - / *");
char inputOperator = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Enter second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(inputOperator == '-')
{
    Console.WriteLine($"The result is: {firstNumber - secondNumber}");
}
else if (inputOperator == '+')
{
    Console.WriteLine($"The result is: {firstNumber + secondNumber}");
}
else if (inputOperator == '/')
{
    Console.WriteLine($"The result is: {firstNumber / secondNumber}");
}
else if (inputOperator == '*')
{
    Console.WriteLine($"The result is: {firstNumber * secondNumber}");
}
else
{
    Console.WriteLine("Wrong operator input. Try again");
}
