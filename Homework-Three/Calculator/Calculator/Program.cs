int sum(int x, int y) { return x + y; };
int subtract(int x, int y) { return x - y; };
int multiply(int x, int y) { return x * y; };
int devide(int x, int y) { return x / y; };

int Calculator()
{

    Console.WriteLine("Enter first number");
    bool successOne = int.TryParse(Console.ReadLine(), out int firstNum);
    Console.WriteLine("Enter Operator + - / *");
    bool operatorSuccess = char.TryParse(Console.ReadLine(), out char operatorInput);
    Console.WriteLine("Enter second number");
    bool successTwo = int.TryParse(Console.ReadLine(), out int secondNum);
    if (successOne && successTwo && operatorSuccess)
    {
        switch (operatorInput)
        {
            case '+':
                return sum(firstNum, secondNum);
            case '-':
                return subtract(firstNum, secondNum);
            case '*':
                return multiply(firstNum, secondNum);
            case '/':
                if (secondNum == 0)
                {
                    Console.WriteLine("Cannot devide with 0");
                    return Calculator();
                }
                else
                {
                    return devide(firstNum, secondNum);
                }
            default:
                Console.WriteLine("Wrong operator; Use + - / *");
                return Calculator();
        };
    }
    else
    {
        Console.WriteLine("Must enter valid numbers!!");
        return Calculator();
    }
}
int resultOfCal = Calculator();
Console.WriteLine($"The result is {resultOfCal}");

