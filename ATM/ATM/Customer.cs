using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected List<long> _cardNumber { get; set; }
        protected int _pin { get; set; }
        protected decimal _balance { get; set; }

        public static List<Customer> _allCustomers = new List<Customer>();
        public Customer()
        {
            _balance = 1000;

        }
        public Customer(string firstName, string lastName, long CardNumber, int pin)
        {
            FirstName = firstName;
            LastName = lastName;
            _balance = 1000;
            _cardNumber = new List<long>() { CardNumber };
            _pin = pin;
            _balance = 1000;
        }
        public void CheckBalance()
        {
            Console.WriteLine($"You balance is {_balance:C} $");
            Operation();
        }
        public void CashWithdrawal(int amount)
        {
            try
            {
                if (amount > _balance)
                {
                    throw new Exception("You don't have that much money. You're a brokie!");
                }

                _balance -= amount;
                Console.WriteLine($"You withdrew {amount:C}. Your balance is now {_balance:C}");

                if (popUp())
                {
                    Operation();
                }
                return;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                Operation();
            }
        }
        public void CashDeposit(int amount)
        {   
            if (amount < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Must enter positive number");
                Console.ResetColor();
                Operation();
            }
            _balance += amount;
            Console.WriteLine($"You deposited {amount}. Your balance is {_balance}");
            if (popUp())
            {
                ;
                Operation();
            }
            return;
        }
        public long CardNumber()
        {
            Console.Write("Enter Card Number in format : 1234-1234-1234-1234. ");
            string input = Console.ReadLine().Replace("-", "");

            if (long.TryParse(input, out long number) && input.Length == 16)
            {
                Console.WriteLine("ATM card number accepted: {0}", number);
                return number;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a valid 16-digit number in the format of 1234-1234-1234-1234.");
            Console.ResetColor();
            return CardNumber();
        }

        public int PinNumber()
        {
            Console.WriteLine("Enter your pin:");
            if (!int.TryParse(Console.ReadLine(), out int pin))
            {
                Console.WriteLine("Pin cannot contain other values than number");
                return PinNumber();
            }
            else
            {
                string pinString = pin.ToString();
                if (pinString.Length != 4)
                {
                    Console.WriteLine("Pin must be 4 characters");
                    return PinNumber();
                }
                return pin;
            }
        }
        public void Operation()
        {

            Console.WriteLine($"Welcome {FirstName} !");
            Console.WriteLine("A. Check Balance \n B. Cash Withdrawal \n C. Cash deposit");
            bool operation = char.TryParse(Console.ReadLine(), out char resolve);
            resolve = char.ToLower(resolve);
            switch (resolve)
            {
                case 'a':
                    CheckBalance();
                    break;
                case 'b':
                    Console.WriteLine("Enter the amount you want to withdraw");
                    CashWithdrawal(ValidateInput());
                    break;
                case 'c':
                    Console.WriteLine("Enter the amount you want to deposit");
                    CashDeposit(ValidateInput());
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    Operation();
                    break;

            }
        }
        public int ValidateInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int amount))
            {
                Console.WriteLine("Invalid input");
                Operation();
            }
            if ( amount <= 0)
            {
                Console.WriteLine("Amount must be positive number");
                Operation();
            }
            return amount;
        }
        public bool popUp()
        {
            Console.WriteLine("Do you want to do another transaction ? Y or N ");
            string question = Console.ReadLine();
            if (question.ToLower() == "y")
            {
                return true;
            }
            return false;
        }
        public void LoginATM()
        {
            Console.WriteLine("enter card number");
            long cardNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter pin");
            int pin = int.Parse(Console.ReadLine());
            foreach (Customer c in _allCustomers)
            {
                if (c._cardNumber.Contains(cardNum) && c._pin == pin)
                {
                    Console.WriteLine("Login Successful");
                    Operation();
                }
            }
            Console.WriteLine("Invalid Card Number or PIN");
            LoginATM();

        }
        public void OpeningMenu()
        {
            Console.WriteLine("Hello. Do you want to create new Account or login into an existing one ?");
            Console.WriteLine("A - to register, B - to login, C - Exit");
            bool option = Char.TryParse(Console.ReadLine(), out char resolve);
            resolve = char.ToLower(resolve);
            switch (resolve)
            {
                case 'a':
                    Console.WriteLine("Register");
                    CreateCustomer();
                    break;
                case 'b':
                    Console.WriteLine("Login");
                    //Customer customer = new Customer("", "");
                    LoginATM();
                    break;
                case 'c':
                    return;
                default:
                    OpeningMenu();
                    break;
            }
        }
        void CreateCustomer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the ATM APP");
            Console.WriteLine("Enter First name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            string lastName = Console.ReadLine();
            long customerCard = CardNumber();
            int customerPin = PinNumber();
            Customer customer = new Customer(firstName, lastName, customerCard, customerPin);
            if (_allCustomers.Exists(x => x.CardNumber() == customer.CardNumber()))// bagira koga ke stavis 2 pati te tera ista karticka da stavis da go frli toa already exists
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Customer with this card number already exists.");
                Console.ResetColor();
                CreateCustomer(); 
                return;
            }
            _allCustomers.Add(customer);
            Console.ResetColor();
            OpeningMenu();
        }

    }
    }




