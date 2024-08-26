using Prism.Scoping.Abstractions;
using Prism.Scoping.Core;
using Prism.Scoping.Features.ScopeB.SubScope;

namespace Prism.Scoping.Features.ScopeC;

public class ScopeCRegistry : ContainerRegistrar
{
    protected internal override IContainerRegistry Register(IContainerRegistry containerRegistry) => containerRegistry
       .RegisterForNavigation<SubScopeC, SubScopeCViewModel>()
       .RegisterForScopedNavigation<OneFish, OneFishViewModel>()
       .RegisterForScopedNavigation<TwoFish, TwoFishViewModel>()
       .RegisterScoped<IScopedInterface, NumberFishScopedService>();
}