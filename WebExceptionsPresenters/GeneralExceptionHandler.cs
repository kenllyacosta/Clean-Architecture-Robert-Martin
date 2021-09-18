using Entities.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace WebExceptionsPresenters
{
    public class GeneralExceptionHandler : ExceptionHandlerBase, IExceptionHandler
    {
        public Task Handle(ExceptionContext exceptionContext)
        {
            var Exception = exceptionContext.Exception as GeneralException;

            return SetResult(exceptionContext, StatusCodes.Status500InternalServerError, Exception.Message, Exception.Detail);
        }
    }
}
