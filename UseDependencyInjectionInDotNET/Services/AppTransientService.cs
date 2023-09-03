using Microsoft.Extensions.DependencyInjection;
using UseDependencyInjectionInDotNET.Contracts;

namespace UseDependencyInjectionInDotNET.Services;

public class AppTransientService : IAppTransientService
{
    public Guid Id { get; } = Guid.NewGuid();

    public ServiceLifetime LifeTime => ServiceLifetime.Transient;

}
