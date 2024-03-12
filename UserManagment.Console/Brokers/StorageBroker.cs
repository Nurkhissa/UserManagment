using System.IO;
using UserManagment.Models;

namespace UserManagment.Brokers
{
    internal class StorageBroker : IStorageBroker
    {
        public static string FilePath = "~/../../../../Assets/Data.txt";

        public StorageBroker() 
        {
            EnsureFileExsists();
        }
        public User AddUser(User user)
        {
            string userLine = $"{user.UserName} - {user.Password}";
            
            File.AppendAllText(FilePath, userLine);

            return user;

        }

        public void EnsureFileExsists()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
        }
    }
}
