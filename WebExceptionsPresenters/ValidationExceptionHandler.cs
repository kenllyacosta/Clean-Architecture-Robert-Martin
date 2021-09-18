using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;
using System.Threading.Tasks;

namespace WebExceptionsPresenters
{
    public class ValidationExceptionHandler : ExceptionHandlerBase, IExceptionHandler
    {
        public Task Handle(ExceptionContext exceptionContext)
        {
            var Exception = exceptionContext.Exception as ValidationException;

            StringBuilder sb = new();
            foreach (var item in Exception.Errors)
            {
                sb.AppendLine($"Property: {item.PropertyName}, Error: {item.ErrorMessage}");
            }

            return SetResult(exceptionContext, StatusCodes.Status400BadRequest, "Error en los datos de entrada", sb.ToString());
        }
    }
}
