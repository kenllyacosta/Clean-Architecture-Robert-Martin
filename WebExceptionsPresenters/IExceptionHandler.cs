using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace WebExceptionsPresenters
{
    public interface IExceptionHandler
    {
        Task Handle(ExceptionContext exception);
    }
}
