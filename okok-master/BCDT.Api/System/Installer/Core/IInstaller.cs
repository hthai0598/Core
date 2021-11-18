using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BCDT.Api.System.Installer
{
    public interface IInstaller
    {
        void InstallerService(IServiceCollection service, IConfiguration configuration);
    }
}
