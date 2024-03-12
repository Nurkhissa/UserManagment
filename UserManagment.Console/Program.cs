using UserManagment.Brokers;
using UserManagment.Models;

namespace UserManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            IStorageBroker broker = new StorageBroker();

            User user = new User
            {
                UserName = "Test",
                Password = "123456"
            };
            //broker.AddUser(user);

            if (broker.CheckForExist("Test", "123456"))
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}


