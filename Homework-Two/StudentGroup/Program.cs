// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] studentsG1 = { "Ivan", "Stefan", "Mitre", "Stevo", "Pavle", "Mitko" };
string[] studentsG2 = { "Kanye", "Andrew", "Tristan", "Drake", "Joe", "Jordan" };
Console.WriteLine("Enter 1 to print the users from G1");
Console.WriteLine("Enter 2 to print the users from G2");
bool success = int.TryParse(Console.ReadLine(), out int input);
if (success)
{
    switch (input)
    {
        case 1:
            Console.WriteLine("The students in G1 are:");
            foreach (string student in studentsG1)
            {
                Console.WriteLine(student);
            };
            break;
        case 2:
            Console.WriteLine("The students in G2 are:");
            foreach (string student in studentsG2)
            {
                Console.WriteLine(student);
            };
            break;
        default:
            Console.WriteLine("Enter 1 or 2 ");
            break;
    }
}


