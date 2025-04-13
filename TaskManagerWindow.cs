using Avalonia.Controls;

namespace PersonalTaskManagerApp;

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



