using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OctopusToolkit.Client.Extensions;

namespace OctopusToolkit.Client;

public static class Startup
{
    private static IHost host;

    public static void Main(string[] args)
    {
        Build();
        Start();
    }

    private static void Build()
    {
        host = Host.CreateDefaultBuilder()
            .AddApplicationServices()
            .Build();
    }

    private static void Start()
    {
        var app = GetAppFromContainer();
        app.Run();
    }

    private static App GetAppFromContainer()
    {
        using var scope = host.Services.CreateScope();
        var provider = scope.ServiceProvider;
        return provider.GetService<App>();
    }
}