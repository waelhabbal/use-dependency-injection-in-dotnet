using Microsoft.Extensions.DependencyInjection;
using UseDependencyInjectionInDotNET.Contracts;
using UseDependencyInjectionInDotNET.Services;

namespace UseDependencyInjectionInDotNET;
public class Program
{
    static void Main(string[] args)
    {
        ServiceProvider services = new ServiceCollection()
            .AddSingleton<IAppSingletonService, AppSingletonService>()
            .AddScoped<IAppScopedService, AppScopedService>()
            .AddTransient<IAppTransientService, AppTransientService>()
            .AddTransient<LoggingService>()
            .BuildServiceProvider();

        ExemplifyLifeTime(services, "Scope 1");
        ExemplifyLifeTime(services, "Scope 2");
    }

    static void ExemplifyLifeTime(ServiceProvider services, string scopeLabel)
    {

        using IServiceScope serviceScope = services.CreateScope();
        IServiceProvider provider = serviceScope.ServiceProvider;

        LoggingService loggingService = provider.GetRequiredService<LoggingService>();
        loggingService.Log($"Scope: {scopeLabel}");

        Console.WriteLine();

        loggingService = provider.GetRequiredService<LoggingService>();
        loggingService.Log($"Scope: {scopeLabel}");

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

    }
}