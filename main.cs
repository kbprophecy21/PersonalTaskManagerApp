using System;

namespace taskmanagerproject {

    class MainProgram {

        static void Main(string[] args) {
            Console.WriteLine("Starting Task Manager...");

            // Create and run the GUI
            var gui = new TaskManagerWindow();
            gui.RunWindow();
        }
    }
}

