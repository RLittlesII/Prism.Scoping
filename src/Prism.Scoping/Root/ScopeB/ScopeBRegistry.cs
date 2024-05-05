using Prism.Scoping.Abstractions;
using Prism.Scoping.Root.ScopeB.SubScope;

namespace Prism.Scoping.Root.ScopeB;

public class ScopeBRegistry : ContainerRegistrar
{
    protected internal override IContainerRegistry Register(IContainerRegistry containerRegistry) => containerRegistry
       .RegisterForNavigation<RootScopeB, RootScopeBViewModel>()
       .RegisterForScopedNavigation<OneFish, OneFishViewModel>()
       .RegisterForScopedNavigation<TwoFish, TwoFishViewModel>()
       .RegisterScoped<IScopedInterface, NumberFishScopedService>();
}