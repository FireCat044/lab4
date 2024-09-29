using lab4.Models;

namespace lab4.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUserById(int id);
    }
}
