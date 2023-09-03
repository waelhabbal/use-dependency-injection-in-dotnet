using Microsoft.Extensions.DependencyInjection;
using UseDependencyInjectionInDotNET.Contracts;

namespace UseDependencyInjectionInDotNET.Services;

public class AppSingletonService : IAppSingletonService
{
    public Guid Id { get; } = Guid.NewGuid();


    public ServiceLifetime LifeTime => ServiceLifetime.Singleton;
}
