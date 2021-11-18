using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace BCDT.Api.System.Middleware
{
    public interface IMiddleware
    {
        void RegisterMiddleware(IApplicationBuilder app, IWebHostEnvironment env);
    }
}
