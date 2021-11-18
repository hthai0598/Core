using Common.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace BCDT.Api.System.Installer
{
    public class CacheInstaller : IInstaller
    {
        public void InstallerService(IServiceCollection services, IConfiguration configuration)
        {
            var redisConfiguration = new RedisCacheSettings();
            configuration.GetSection("RedisCacheSettings").Bind(redisConfiguration);
            services.AddSingleton(redisConfiguration);
            if (!redisConfiguration.Enable)
                return;
            services.AddSingleton<IConnectionMultiplexer>(_ => ConnectionMultiplexer.Connect(redisConfiguration.ConnectionString + redisConfiguration.Host));
        }
    }
}
