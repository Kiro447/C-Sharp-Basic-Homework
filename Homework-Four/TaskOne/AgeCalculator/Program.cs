using System.ComponentModel;
using System.Transactions;

void AgeCalculator()
{
    Console.Write("Enter birthday MM.DD.YYYY : ");
    bool success = DateTime.TryParse(Console.ReadLine(), out DateTime birthDay);
    if (success)
    {
        Console.WriteLine(birthDay);
        DateTime Today = DateTime.Today;
        Console.WriteLine(Today);
        int age = Today.Year - birthDay.Year;

        if (birthDay > Today.AddYears(-age)) // stackoverflow
        {
            age--;
        }
        Console.WriteLine(age);
    }
    else
    {
        Console.WriteLine("Wrong input");
        AgeCalculator();
    }

}

AgeCalculator();
