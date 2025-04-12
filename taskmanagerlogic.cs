using System;
using System.Collections.Generic;


namespace taskmanagerproject
{
    class TaskManagerLogic
    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public List<string> GetAllTasks()
        {
            return tasks;
        }

        public void RemoveTask(string task)
        {
            tasks.Remove(task);
        }

        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }

        public void RemoveAllTasks()
        {
            tasks.Clear();
        }

    }
}
