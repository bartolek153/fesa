using System.Net;

using Core.Interfaces;

namespace Core.Exceptions;

public class DuplicateEmailException : Exception, IError
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;
    public string ErrorMessage => "Email already exists";
}
