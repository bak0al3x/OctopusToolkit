using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OctopusToolkit.Client.Configuration;

namespace OctopusToolkit.Client.Extensions;

public static class ConfigRegister
{
    public static IHostBuilder AddOptions(this IHostBuilder builder)
    {
        builder.ConfigureServices((context, services) =>
        {
            var configRoot = context.Configuration;
            var octopusServerConfig = configRoot.GetSection("Octopus");
            services.Configure<OctopusServerOptions>(octopusServerConfig);
        });
        
        return builder;
    }
}