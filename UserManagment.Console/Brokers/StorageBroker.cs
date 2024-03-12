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

        public bool CheckForExist(string username, string password)
        {
            try
            {
                string[] lines = File.ReadAllLines(FilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('-');
                    if (parts.Length == 2 && parts[0].Trim() == username && parts[1].Trim() == password)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error  {ex.Message}");
                return false;
            }
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
