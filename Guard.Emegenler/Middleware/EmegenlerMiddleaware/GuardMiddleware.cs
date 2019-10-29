using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Guard.Emegenler.Middleware.EmegenlerMiddleaware
{
    public class GuardMiddleware
    {
        private readonly RequestDelegate _next;


        public GuardMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.OnStarting(async () =>
            {
                GuardPolicyExecuter policyExecuter = new GuardPolicyExecuter(context);
                var result = policyExecuter.CheckPolicy(context.Request.Path.ToString());
                if (result.IsSuccess())
                {
                    var policy = result.GetData();
                    if (policy.AccessProtocol == "AccessDenied")
                    {
                        context.Response.Redirect("/home");//This line have to come in Options redirect
                    }
                    else
                    {
                        await _next.Invoke(context);
                    }

                }
                else
                {
                    
                }
            });
            await _next.Invoke(context);

        }
    }
}
