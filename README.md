# Task Tracker CLI

A robust Command-Line Interface (CLI) application built with **C#** and **.NET 8** to manage your daily tasks. This project was developed as part of the [Task Tracker](https://roadmap.sh/projects/task-tracker) challenge from roadmap.sh.

---

## 🚀 Features

* **File Persistence:** All tasks are automatically saved and managed in a local `Tasks.json` file.
* **Complete Task Management:**
    * **Add:** Quickly create new tasks.
    * **Delete:** Remove specific tasks using their list index.
    * **List:** View all registered tasks in a clean, numbered format.
* **Error Handling:** Implements `int.TryParse` and input validation to prevent crashes from invalid user entries.
* **Interactive Loop:** A dynamic menu that allows multiple operations without restarting the app.

## 🛠️ Technical Stack

* **Language:** C#
* **Runtime:** .NET 8.0
* **I/O Operations:** `System.IO` for file handling and data persistence.



## 📋 Prerequisites

* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed on your machine.
* A terminal or command prompt.

## 🔧 Installation & Setup

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/JonathanManzanoDiaz/Task-Tracker-CLI.git](https://github.com/JonathanManzanoDiaz/Task-Tracker-CLI.git)
      
2. Execution
Run the application using the .NET CLI:

Bash
dotnet run
3. Menu Options
Once launched, navigate using the following options:

Press 1: Add a new task (e.g., "Review pull requests").

Press 2: Delete a task (you will be asked for the task number).

Press 3: List all tasks saved in the system.

Press 0: Exit the application.

📂 Project Structure
Program.cs: Contains the main logic and menu system.

Tasks.json: Local database where your tasks are stored (automatically created if it doesn't exist).

.gitignore: Configured to exclude bin/ and obj/ folders to maintain a clean repository.

📌 Roadmap
[ ] Task Status: Add support for todo, in-progress, and done.

[ ] Search: Implement keyword search functionality.

[ ] JSON Serialization: Migrate from plain text to proper JSON objects using System.Text.Json.

⚖️ License
This project is licensed under the MIT License - see the LICENSE file for details.