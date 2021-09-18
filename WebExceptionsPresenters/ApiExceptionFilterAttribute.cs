using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;

namespace WebExceptionsPresenters
{
    public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        readonly IDictionary<Type, IExceptionHandler> ExceptionHandlers;
        public ApiExceptionFilterAttribute(IDictionary<Type, IExceptionHandler> exceptionHandlers)
        {
            ExceptionHandlers = exceptionHandlers;
        }

        public override void OnException(ExceptionContext context)
        {
            Type exceptionType = context.Exception.GetType();
            if (ExceptionHandlers.ContainsKey(exceptionType))
            {
                ExceptionHandlers[exceptionType].Handle(context);
            }
            else
            {
                new ExceptionHandlerBase().SetResult(context, StatusCodes.Status500InternalServerError, "Ha ocurrido un error al procesar la respuesta", "Sin detalles :p");
            }

            base.OnException(context);
        }
    }
}
