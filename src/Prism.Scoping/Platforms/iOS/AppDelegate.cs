using Foundation;

namespace Prism.Scoping.Platforms.iOS;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp(MauiApp.CreateBuilder());
}