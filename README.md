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