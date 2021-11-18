using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BCDT.Api.System.Installer
{
    public static class InstallerExtenstions
    {
        public static void InstallerServiceInAssembly(this IServiceCollection service, IConfiguration configuration)
        {
            var installer = typeof(Startup).Assembly.ExportedTypes
                .Where(x => typeof(IInstaller)
                .IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(Activator.CreateInstance)
                .Cast<IInstaller>()
                .ToList();

            installer.ForEach(installer => installer.InstallerService(service, configuration));
        }
    }
}
