﻿using Foundation;

namespace Prism.Scoping;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp(MauiApp.CreateBuilder());
}