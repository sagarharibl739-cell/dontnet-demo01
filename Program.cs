using dotnet_demo;   // 👈 THIS LINE FIXES EVERYTHING

var taskManager = new TaskManager();

Console.WriteLine("Task Tracker Demo");
Console.WriteLine("=================");
Console.WriteLine($"Pending tasks: {taskManager.GetPendingTaskCount()}");
Console.WriteLine($"Completed tasks: {taskManager.GetCompletedTaskCount()}");
Console.WriteLine($"Next task: {taskManager.GetNextTask()}");