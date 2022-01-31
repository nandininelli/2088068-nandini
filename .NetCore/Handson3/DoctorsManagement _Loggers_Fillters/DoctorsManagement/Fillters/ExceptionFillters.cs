using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsManagement.Fillters
{
    public class ExceptionFillters:IExceptionFilter
    {
       
private readonly ILogger<ExceptionFillters> logger;
        public ExceptionFillters(ILogger<ExceptionFillters> logger)
        {
            this.logger = logger;
        }
        public void OnException(ExceptionContext context)
        {
            context.ExceptionHandled = true;
            logger.LogError("Exception is occured");
            var message = context.Exception.Message;
            var stacktrace = context.Exception.StackTrace;
            var innerException = context.Exception.InnerException;
            logger.LogError(message);
            logger.LogError(stacktrace);
            if (context.Exception is NotImplementedException)
            {
                var view = new ViewResult { ViewName = "Error1" };
                context.Result = view;
            }
            else if (context.Exception is ArgumentException)
            {
                var view = new ViewResult { ViewName = "Error2" };
                context.Result = view;
            }
        }


    }
}
