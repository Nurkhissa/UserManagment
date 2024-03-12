using UserManagment.Models;
namespace UserManagment.Brokers
{
    internal interface IStorageBroker
    {
        User AddUser(User user);
        bool CheckForExist(string username, string password);
    }
}
