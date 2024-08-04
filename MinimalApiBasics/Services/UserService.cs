using MinimalApiBasics.Models;

namespace MinimalApiBasics.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _Users = new List<User>
    {
        new User { Id=0, UserName = "John Doe", Email = "NewYork@gmail.com" },
        new User {  Id=1, UserName = "Jane Smith", Email = "London@hotmail.com" }
    };

        public IEnumerable<User> GetAllUsers() => _Users;

        public User GetUserById(int id) => _Users.FirstOrDefault(c => c.Id == id);

        public void AddUser(User User) => _Users.Add(User);

        public void UpdateUser(int id, User User)
        {
            var existingUser = GetUserById(id);
            if (existingUser != null)
            {
                existingUser.UserName = User.UserName;
                existingUser.Email = User.Email;
            }
        }

        public void DeleteUser(int id)
        {
            var User = GetUserById(id);
            if (User != null)
            {
                _Users.Remove(User);
            }
        }
    }
}
