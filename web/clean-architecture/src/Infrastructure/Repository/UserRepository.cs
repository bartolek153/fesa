using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByEmail(string email) => _users.SingleOrDefault(u => u.Email == email);
}
