using UseDependencyInjectionInDotNET.Contracts;
using UseDependencyInjectionInDotNET.Extensions;

namespace UseDependencyInjectionInDotNET.Services;

public class LoggingService
{
    private readonly IAppSingletonService _appSingletonService;
    private readonly IAppScopedService _appScopedService;
    private readonly IAppTransientService _appTransientService;

    public LoggingService(IAppSingletonService appSingletonService,
        IAppScopedService appScopedService,
        IAppTransientService appTransientService)
    {
        _appSingletonService = appSingletonService;
        _appScopedService = appScopedService;
        _appTransientService = appTransientService;
    }

    public void Log(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("===============");
        Console.WriteLine(GetServiceDetails(_appSingletonService, "Always the same"));
        Console.WriteLine(GetServiceDetails(_appScopedService, "Same for same scope"));
        Console.WriteLine(GetServiceDetails(_appTransientService, "Always different"));
    }

    private static string GetServiceDetails<T>(T service, string explainMessage) where T : IAppService
    {
        return $"[{service.LifeTime.ToString().ToLength(9)}] Type: {service.GetType().Name.ToLength(19)}, ID: {service.Id} :: {explainMessage}";
    }
}
