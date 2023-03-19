

//Task One

Console.WriteLine("Enter a sentance, you will get the last 5 letters");
string newSentance = Console.ReadLine();
if (newSentance.Length >= 5)
{
    string lastFive = newSentance.Substring(newSentance.Length - 5);
    Console.WriteLine(lastFive);
}
else
{
    Console.WriteLine("Enter new sentance longer that 5 characters");
}



//TaskTwo
Console.WriteLine("Enter a sentance, you will get the words splitted");
string sentance = Console.ReadLine();
if (sentance.Length != 0)
{
    string[] wordsOfSentance = sentance.Split(" ");
    foreach (string word in wordsOfSentance)
    {
        Console.WriteLine(word);
    }
}
else
{
    Console.WriteLine("Input cannot be empty");
}


//TaskThree
int first;
int sum = 0;
Console.WriteLine("Enter number and get sum of its digits");
bool success = int.TryParse(Console.ReadLine(), out int numberInput);
if (success)
{
    int referenceNumber = numberInput;
    while (numberInput != 0)
    {
        first = numberInput % 10;
        numberInput /= 10;
        sum += first;
    }
    Console.WriteLine($"The sum of numbers of {referenceNumber} is {sum}");
}
else
{
    Console.WriteLine("Wrong input");
}