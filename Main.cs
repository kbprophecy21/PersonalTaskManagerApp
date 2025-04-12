using Avalonia;
using System;

namespace PersonalTaskManagerApp;

class Main
{
    // This is the main entry point for the application.
    // The Main method is the starting point of the application.
    // It initializes the application and starts the main event loop.
    // The BuildAvaloniaApp method configures the Avalonia application.
    // It sets up platform detection, font configuration, and logging.

    // The Main method is marked with [STAThread] to indicate that it should run in a single-threaded apartment.
    // This is important for certain UI frameworks to ensure thread safety.
    {
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
    }

}