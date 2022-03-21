using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace OctopusToolkit.Client.Extensions;

public static class AppConfigurationRegister
{
    public static IHostBuilder AddAppConfiguration(
        this IHostBuilder builder, string fileName = "appsettings.json")
    {
        builder.ConfigureAppConfiguration(
            app => app.AddJsonFile(fileName));

        return builder;
    }
}