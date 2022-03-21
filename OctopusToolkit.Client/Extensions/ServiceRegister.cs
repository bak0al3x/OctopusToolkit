using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace OctopusToolkit.Client.Extensions;

public static class ServiceRegister
{
    public static IHostBuilder AddApplicationServices(this IHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            services.AddSingleton<App>();
        });

        return builder;
    }
}