using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PublicApi.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        var details = new ProblemDetails
        {
            Type = "https://www.rfc-editor.org/rfc/rfc9110#name-500-internal-server-error",
            Title = "An error occurred wihle processing your request. (2)",
            Status = (int)HttpStatusCode.InternalServerError
        };

        var errorResult = new { error = "An error occurred while processing the request. (2)" };

        context.Result = new ObjectResult(errorResult)
        {
            StatusCode = 500
        };

        context.ExceptionHandled = true;
    }
}
