using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Users
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
        public void Messages()
        {
            Console.WriteLine($"Test message 1");
            Console.WriteLine($"Test message 2\n");
        }
        public Guid guid = Guid.NewGuid();

    }

}
