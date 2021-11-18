using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Linq;

namespace BCDT.Api.System.Middleware
{
    public static class MiddlewareExtenstions
    {
        public static void RegisterPipelineInAssembly(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            //lay ra het cac class trong thu muc install, bo di nhung interface, abstract
            var installer = typeof(Startup).Assembly.ExportedTypes
                .Where(x => typeof(IMiddleware)
                .IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(Activator.CreateInstance)
                .Cast<IMiddleware>()
                .ToList();

            installer.ForEach(installer => installer.RegisterMiddleware(app, env));
        }
    }
}
