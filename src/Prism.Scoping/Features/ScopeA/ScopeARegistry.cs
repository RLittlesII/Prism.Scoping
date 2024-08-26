using Prism.Scoping.Abstractions;
using Prism.Scoping.Core;
using Prism.Scoping.Features.ScopeA.SubScope;

namespace Prism.Scoping.Features.ScopeA;

public class ScopeARegistry : ContainerRegistrar
{
    protected internal override IContainerRegistry Register(IContainerRegistry containerRegistry) => containerRegistry
       .RegisterForNavigation<RootScopeA, RootScopeAViewModel>()
       .RegisterForScopedNavigation<RedFish, RedFishViewModel>()
       .RegisterForScopedNavigation<BlueFish, BlueFishViewModel>()
       .RegisterScoped<IScopedInterface, ColoredFishScopedService>();
}