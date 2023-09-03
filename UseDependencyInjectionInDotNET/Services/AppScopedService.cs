using Microsoft.Extensions.DependencyInjection;
using UseDependencyInjectionInDotNET.Contracts;

namespace UseDependencyInjectionInDotNET.Services;

public class AppScopedService : IAppScopedService
{
    public Guid Id { get; } = Guid.NewGuid();

    public ServiceLifetime LifeTime => ServiceLifetime.Scoped;
}
