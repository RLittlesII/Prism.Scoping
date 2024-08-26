using Microsoft.Extensions.Logging;
using Prism.Scoping.Core;
using Prism.Scoping.Features;
using Prism.Scoping.Features.ScopeA;
using Prism.Scoping.Features.ScopeB;

namespace Prism.Scoping;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp(MauiAppBuilder builder)
    {
        builder
           .UseMauiApp<App>()
           .UsePrism(
                prism =>
                    prism
                       .CreateWindow((_, navigation) => navigation.NavigateAsync(Routes.Main))
                       .RegisterTypes(
                            registry => registry
                               .RegisterForNavigation<MainPage, MainViewModel>(Routes.Main)
                               .Register<RootRegistry>()
                               .Register<ScopeARegistry>()
                               .Register<ScopeBRegistry>()
                        )
            )
           .ConfigureFonts(
                fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }
            );

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}