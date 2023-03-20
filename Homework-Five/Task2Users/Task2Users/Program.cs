
using Task2Users;

User[] arrayOfUsers = new User[10];

arrayOfUsers[0] = new User(idCreator(), "kiril", "sedc");
arrayOfUsers[1] = new User(idCreator(), "stefan", "cdes");
arrayOfUsers[2] = new User(idCreator(), "dana", "endava");

string idCreator()
{
    Guid guid = Guid.NewGuid(); // https://stackoverflow.com/questions/11313205/generate-a-unique-id 
    string str = guid.ToString(); // Koga dojdov da davam ID na register izguglav za random ID
    return str;// istraziv malce i ja napraviv metodava da mi dava random sekoj pat =)
} 

void startingPlace()
{
    Console.WriteLine("Enter 1 for login, enter 2 for register, 0 to exit");
    bool success = int.TryParse(Console.ReadLine(), out int userChoice);
    if (success)
    {
        switch (userChoice)
        {
            case 0:
                Console.WriteLine("Exiting");
                break;
            case 1:
                loginMethod();
                break;
            case 2:
                registerMethod();
                break;
            default:
                startingPlace();
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid Input\n");
        startingPlace();
    }
};
startingPlace();

void loginMethod()
{
    Console.WriteLine("Enter your username to login");
    string usernameInput = Console.ReadLine().ToLower();
    string noExistance = "Such user does not exist\n";
    bool userFound = false;
    foreach (User user in arrayOfUsers)
    {
        if (user != null && user.Username == usernameInput)
        {
            userFound = true;
            Console.WriteLine("Enter password to login");
            string passwordInput = Console.ReadLine();
            if (passwordInput == user.Password && passwordInput != null)
            {
                user.Messages();
                startingPlace();
                break;
            }
            Console.WriteLine("Wrong password\n");
            startingPlace();
            break;
        }
    }
    if (!userFound)
    {
        Console.WriteLine(noExistance);
        startingPlace();
    }
}

void registerMethod()
{
    Console.WriteLine("Enter username to register");
    string usernameInput = Console.ReadLine();
    int counter = 2;
    bool usernameExists = false;
    foreach (User user in arrayOfUsers)
    {
        if (user != null && user.Username == usernameInput)
        {
            Console.WriteLine("Username already exists. Please choose a different username.");
            usernameExists = true;
            registerMethod();
            break;
        }
    }
    if (!usernameExists)
    {
        if (usernameInput.Length <= 5)
        {
            Console.WriteLine("Username must be longer than 5 characters");
            registerMethod();
        }
        else
        {
            Console.WriteLine("Enter Password to register");
            string passwordInput = Console.ReadLine();
            if (passwordInput.Length <= 5)
            {
                Console.WriteLine("Password must be longer than 5 characters");
                registerMethod();
            }
            counter++;
            arrayOfUsers[counter] = new User(idCreator(), usernameInput, passwordInput);
            Console.WriteLine("All registered users:");
            foreach (User user in arrayOfUsers)
            {
                if (user != null)
                {
                    Console.WriteLine(user.Username);
                }
            }
            loginMethod();
        }
    }
}




