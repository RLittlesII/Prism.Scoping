using Prism.Scoping.Abstractions;
using Prism.Scoping.Root.ScopeA.SubScope;

namespace Prism.Scoping.Root.ScopeA;

public class ScopeARegistry : ContainerRegistrar
{
    protected internal override IContainerRegistry Register(IContainerRegistry containerRegistry) => containerRegistry
       .RegisterForNavigation<RootScopeA, RootScopeAViewModel>()
       .RegisterForScopedNavigation<RedFish, RedFishViewModel>()
       .RegisterForScopedNavigation<BlueFish, BlueFishViewModel>()
       .RegisterScoped<IScopedInterface, ColoredFishScopedService>();
}