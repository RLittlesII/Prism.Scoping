using Prism.Scoping.Abstractions;
using Prism.Scoping.Core;
using Prism.Scoping.Features.ScopeB.SubScope;

namespace Prism.Scoping.Features.ScopeB;

public class ScopeBRegistry : ContainerRegistrar
{
    protected internal override IContainerRegistry Register(IContainerRegistry containerRegistry) => containerRegistry
       .RegisterForNavigation<ScopeC.SubScopeC, RootScopeBViewModel>()
       .RegisterForScopedNavigation<OneFish, OneFishViewModel>()
       .RegisterForScopedNavigation<TwoFish, TwoFishViewModel>()
       .RegisterScoped<IScopedInterface, NumberFishScopedService>();
}