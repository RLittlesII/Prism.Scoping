using Microsoft.Extensions.Logging;
using Prism.Scoping.Root;
using Prism.Scoping.Root.ScopeA;
using Prism.Scoping.Root.ScopeB;

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
                       .OnInitialized(
                            provider =>
                                provider
                                   .Resolve<INavigationService>()
                                   .NavigateAsync(Routes.Main)
                                   .GetAwaiter()
                                   .GetResult()
                        )
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