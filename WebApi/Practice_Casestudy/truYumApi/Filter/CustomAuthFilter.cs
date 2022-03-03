using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace truYumApi.Filter
{
    public class CustomAuthFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                var barer = context.HttpContext.Request.Headers[HeaderNames.Authorization];
                if(barer.ToString() != "")
                {
                    var token = context.HttpContext.Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer", "");
                    if (token == "")
                    {
                        context.Result = new BadRequestObjectResult("Invalid request - Token Present but Bearer unavailable");

                    }
                    else
                    {
                        context.Result = new BadRequestObjectResult("Invalid request - No Auth token.");

                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
