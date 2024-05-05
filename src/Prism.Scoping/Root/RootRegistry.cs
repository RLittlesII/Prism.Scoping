using Prism.Scoping.Abstractions;

namespace Prism.Scoping.Root;

public class RootRegistry : ContainerRegistrar
{
    protected internal override IContainerRegistry Register(IContainerRegistry containerRegistry) => containerRegistry
       .RegisterForNavigation<RootLeaf, RootLeafViewModel>()
       .RegisterSingleton<ISingletonInterface, RootSingletonService>()
       .RegisterScoped<IScopedInterface, RootScopedService>()
       .Register<ITransientInterface, RootTransientService>();
}