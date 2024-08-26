using Prism.Scoping.Abstractions;
using Prism.Scoping.Core;
using Prism.Scoping.Features.Leaf;

namespace Prism.Scoping.Features;

public class RootRegistry : ContainerRegistrar
{
    protected internal override IContainerRegistry Register(IContainerRegistry containerRegistry) => containerRegistry
       .RegisterForNavigation<RootLeaf, RootLeafViewModel>(Routes.Leaf)
       .RegisterSingleton<ISingletonInterface, RootSingletonService>()
       .RegisterScoped<IScopedInterface, RootScopedService>()
       .Register<ITransientInterface, RootTransientService>();
}