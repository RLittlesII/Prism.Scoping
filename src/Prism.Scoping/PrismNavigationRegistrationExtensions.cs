using Prism.Scoping.Root;
using System.Diagnostics.CodeAnalysis;

namespace Prism.Scoping;

public static class PrismNavigationRegistrationExtensions
{
    public static IContainerRegistry Register<T>(this IContainerRegistry container)
        where T : ContainerRegistrar, new() => Register(container, new T());

    public static IContainerRegistry Register(this IContainerRegistry container, ContainerRegistrar module) => module.Register(container);

    public static IContainerRegistry RegisterForScopedNavigation<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] TView,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] TViewModel>(
        this IContainerRegistry container,
        string? name = null
    )
        where TView : Page => container.RegisterForScopedNavigation(typeof(TView), typeof(TViewModel), name);

    public static IContainerRegistry RegisterForScopedNavigation(this IContainerRegistry container, Type? view, Type? viewModel, string? name = null)
    {
        ArgumentNullException.ThrowIfNull(view);

        if (string.IsNullOrEmpty(name))
            name = view.Name;

        container.RegisterInstance(
                new ViewRegistration
                {
                    Type = ViewType.Page,
                    Name = name,
                    View = view,
                    ViewModel = viewModel
                }
            )
           .Register(view);

        if (viewModel != null)
            container.RegisterScoped(viewModel);

        return container;
    }
}