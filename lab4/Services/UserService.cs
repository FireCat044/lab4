using lab4.Models;
using lab4.Services.Interfaces;
using Newtonsoft.Json;


namespace lab4.Services
{
    public class UserService : IUserService
    {
        private readonly string _usersFilePath = "Profiles.json";

        public List<User> GetUsers()
        {
            if (File.Exists(_usersFilePath))
            {
                var jsonData = File.ReadAllText(_usersFilePath);
                return JsonConvert.DeserializeObject<List<User>>(jsonData);
            }
            return new List<User>();
        }

        public User GetUserById(int id)
        {
            var users = GetUsers();
            return users.Find(u => u.Id == id);
        }
    }
}
