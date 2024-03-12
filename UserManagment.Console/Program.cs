using System.ComponentModel;
using UserManagment.Brokers;
using UserManagment.Models;

namespace UserManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            IStorageBroker broker = new StorageBroker();

            while (true)
            {
                Console.WriteLine(
                    "1.Create\n" +
                    "2.Login\n" +
                    "3.Exit");

                Console.Write(">");
                int inputNumber = int.Parse( Console.ReadLine() );

                if (inputNumber == 1)
                {
                    Console.Write("Username: ");
                    string name = Console.ReadLine();
                    Console.Write("Password: ");
                    string pass = Console.ReadLine();

                    User user = new User()
                    {
                        UserName = name,
                        Password = pass
                    };
                    broker.AddUser(user);
                    Console.WriteLine("Entered successfully");
                }

                else if (inputNumber == 2)
                {
                    while (true)
                    {
                        Console.Write("Username: ");
                        string EnteredName = Console.ReadLine();
                        Console.Write("Password: ");
                        string EnteredPassword = Console.ReadLine();

                        if (broker.CheckForExist(EnteredName, EnteredPassword))
                        {
                            Console.WriteLine("You have successfully logged in");
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Invalid! Try again");
                        }

                    }
                    

                }

            }

            
            

            
        }
    }
}


