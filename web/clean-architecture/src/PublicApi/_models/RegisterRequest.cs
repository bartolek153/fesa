namespace PublicApi._models;

public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string Password
);
