﻿using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MauiApp1
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}