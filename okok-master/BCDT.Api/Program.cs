using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace BCDT.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostContext, config) =>
            {
                var env = hostContext.HostingEnvironment;

                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

                config.AddJsonFile("config/connections.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"config/connections.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

                config.AddJsonFile("config/commonApp.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"config/commonApp.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

                config.AddJsonFile("config/jwt.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"config/jwt.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

                config.AddJsonFile("config/redis.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"config/redis.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
            })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
