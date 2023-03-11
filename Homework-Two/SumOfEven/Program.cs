// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] arrOfNums = new int[6];
int counter = 0;


Console.WriteLine("Enter 6 numbers into array and find the sum of all even numbers that you entered");
while (counter <= 5)
{
    Console.WriteLine($"Enter number");
    bool success = int.TryParse(Console.ReadLine(), out int number);

    if (success)
    {
        Console.WriteLine($"{number} was added to the array");
        arrOfNums[counter] = number;
        counter++;

    }
    else
    {
        Console.WriteLine("Error ! 2" +
            "You must enter numbers !");
    }
}

int sum = 0;

foreach (int number in arrOfNums)
{
    if (number % 2 == 0)
    {
        sum += number;
    }

}

Console.WriteLine($"The sum of the even numbers is {sum}");

