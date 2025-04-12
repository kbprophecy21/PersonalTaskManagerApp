using System;
using System.Windows;

namespace taskmanagerproject {

    public class TaskManagerWindow : Application {
        public void RunWindow() {
            var window = new Window { Title = "Task Manager GUI" };
            this.Run(window);
        }
    }
}



