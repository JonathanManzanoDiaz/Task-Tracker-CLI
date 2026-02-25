namespace TaskTracker {
    internal class Program {
        public static void NewTask(string route) {
            Console.Write("\nNew task: ");
            string? newTask = Console.ReadLine();

            if (newTask == null || newTask == string.Empty) {
                Console.WriteLine("The task can't be empty.");
                return;
            } else {
                File.AppendAllText(route, newTask + Environment.NewLine);
                Console.WriteLine("Task Added Succesfully!\n");
                AllTasks(route);
            }
        }

        public static void DeleteTask(string route) {
            string[] tasks = File.ReadAllLines(route);

            if (tasks.Length == 0) {
                Console.WriteLine("No tasks to delete.\n");
                return;
            }
            for (int i = 0; i < tasks.Length; i++) {
                Console.WriteLine($"{i + 1}.- {tasks[i]}");
            }

            Console.Write("\nEnter the number of the task you want to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index)) {
                // Adjust the number for the array
                int realIndex = index - 1;

                if (realIndex >= 0 && realIndex < tasks.Length) {
                    // 3. Create a new list without the deleted element
                    var taskList = tasks.ToList();
                    taskList.RemoveAt(realIndex);

                    // 4. Rewrite all the file
                    File.WriteAllLines(route, taskList);
                    Console.WriteLine("Task deleted successfully!\n");
                } else {
                    Console.WriteLine("Invalid index.\n");
                }
            }
        }
        public static void AllTasks(string route) {
            string[] tasks = File.ReadAllLines(route);
            if (tasks.Length == 0) {
                Console.WriteLine("\nTasks is empty!");
                return;
            }
            Console.WriteLine("\n--- CURRENT TASKS ---");
            foreach (string t in tasks) {
                Console.WriteLine("- " + t);
            }
        }
        static void Main(string[] args) {

            string route = "Tasks.json";
            // Verify if the file exists...
            if (!File.Exists(route)) {
                // Creates the file
                File.WriteAllText(route, string.Empty);
            } 
            
            bool exitTask = true;

            while (exitTask) {
                Console.WriteLine("\n=== Welcome to Task Tracker! ===");
                Console.WriteLine("1.- Add New Task: ");
                Console.WriteLine("2.- Delete Task.: ");
                Console.WriteLine("3.- All Task: ");
                Console.WriteLine("0.- Exit: ");
                Console.Write("\nSelect an Option: ");

                int selected = Convert.ToInt32(Console.ReadLine());

                if (selected == 1) {
                    NewTask(route);
                } else if (selected == 2) {
                    DeleteTask(route);
                } else if (selected == 3) {
                    AllTasks(route);
                } else if (selected == 0) {
                    exitTask = false;
                    Console.WriteLine("Goodbye!");
                }

            }
        }
    }
}

