using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.filter
{//custom Authorization   day2 2nd  2nd bit
    public class CustomAuthFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            if (!(context.ToString().Contains("Authorization"))){
                context.Result = new BadRequestObjectResult("Invalid request-No Auth token");

            }
            else if(!(context.ToString().Contains("Bearer")))
            
                    {
                context.Result = new BadRequestObjectResult("Invalid request - Token present but Bearer unavailable");

            }
            else
            {
                context.Result = new BadRequestObjectResult("Valid Token");
            }
        }
    }
}
