using System.Net;

namespace Core.Interfaces;

public interface IError
{
    public HttpStatusCode StatusCode { get; }
    public string ErrorMessage { get; }
}
