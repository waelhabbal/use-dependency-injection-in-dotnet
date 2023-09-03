using Microsoft.Extensions.DependencyInjection;

namespace UseDependencyInjectionInDotNET.Contracts;

public interface IAppService
{
    Guid Id { get; }

    //enum .. Singleton, Scoped, Transient
    ServiceLifetime LifeTime { get; }
}
