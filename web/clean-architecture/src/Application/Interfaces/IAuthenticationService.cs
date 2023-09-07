namespace Application.Interfaces;

public interface IAuthenticationService
{
    string Register(string firstName, string lastName, string email, string password);
    void Login(string email, string password);
}
