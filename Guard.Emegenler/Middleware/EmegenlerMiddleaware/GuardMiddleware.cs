using Guard.Emegenler.Options;
using Guard.Emegenler.Types;
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

        public async Task Invoke(HttpContext context, EmegenlerOptions options)
        {
            context.Response.OnStarting(async () =>
            {
                EmegenlerSecurePage policyExecuter = new EmegenlerSecurePage(context);
                var result = policyExecuter.CheckPolicy(context.Request.Path.ToString());
                if (result.IsSuccess())
                {
                    var policy = result.GetData();
                    if (policy.AccessProtocol == AccessProtocol.AccessDenied)
                    {
                        context.Response.Redirect(options.PageAccessDeniedUrl);
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
