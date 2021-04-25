using DesignPatternsConsole.Logic.Creational;
using DesignPatternsConsole.Logic.Structural;
using DesignPatternsConsole.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;

namespace DesignPatternsConsole
{
    internal static class Startup
    {
        internal static IServiceCollection ConfigureServices(string parameter)
        {
            var services = new ServiceCollection();

            var configuration = CreateConfiguration();
            services.AddConfigurationSettings(configuration);

            services.AddLogging(c =>
            {
                c.AddConfiguration(configuration.GetSection("Logging"));
                c.AddConsole();
            });

            services.AddHttpClient();

            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();

            switch (parameter)
            {
                case "DECORATOR":
                    services.AddSingleton<DecoratorPattern>();
                    break;
                case "FLYWEIGHT":
                    services.AddSingleton<SingletonPattern>();
                    break;
                default:
                    break;
            }

            return services;
        }

        private static IConfigurationRoot CreateConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .AddEnvironmentVariables();
            return builder.Build();
        }

        private static void AddConfigurationSettings(this IServiceCollection services, IConfigurationRoot configuration)
        {
            var appSettings = new AppSettings();
            configuration.Bind("appSettings", appSettings);
            services.AddSingleton(appSettings);
        }
    }
}
