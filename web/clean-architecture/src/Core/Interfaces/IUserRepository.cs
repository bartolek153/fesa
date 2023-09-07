using Core.Entities;

namespace Core.Interfaces;

public interface IUserRepository
{
    void AddUser(User user);
    User? GetUserByEmail(string email);
}
