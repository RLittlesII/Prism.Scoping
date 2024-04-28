using Microsoft.Extensions.Logging;

namespace Prism.Scoping;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UsePrism(prism =>
                prism
                    .OnInitialized(provider =>
                        provider
                            .Resolve<INavigationService>()
                            .NavigateAsync("Root")
                            .GetAwaiter()
                            .GetResult())
                    .RegisterTypes(registry => registry
                        .RegisterForNavigation<MainPage, MainViewModel>("Root")))
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}