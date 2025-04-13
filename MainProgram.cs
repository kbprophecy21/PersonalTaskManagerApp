using Avalonia;
using System;
using Avalonia.Controls;

namespace PersonalTaskManagerApp;

class MainProgram
{
    // This is the main entry point for the application.
    // The Main method is the starting point of the application.
    // It initializes the application and starts the main event loop.
    // The BuildAvaloniaApp method configures the Avalonia application.
    // It sets up platform detection, font configuration, and logging.

    // The Main method is marked with [STAThread] to indicate that it should run in a single-threaded apartment.
    // This is important for certain UI frameworks to ensure thread safety.

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

public class TaskManagerWindow : Window
{
    public TaskManagerWindow()
    {
        this.Title = "Task Manager GUI";
        this.Width = 400;
        this.Height = 300;

        // Example content
        var stackPanel = new StackPanel();
        stackPanel.Children.Add(new TextBlock { Text = "Welcome to the Task Manager!" });
        stackPanel.Children.Add(new Button { Content = "Click Me" });

        this.Content = stackPanel;
    }
}