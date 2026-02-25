# Task Tracker CLI

A lightweight and efficient Command-Line Interface (CLI) application built with **C#** and **.NET 8**. This project is a practical implementation of the [Task Tracker](https://roadmap.sh/projects/task-tracker) challenge from roadmap.sh.

---

## 🚀 Features

* **File Persistence:** Automatically handles data using a local `Tasks.json` file.
* **Dynamic CRUD Operations:**
    * **Add:** Insert new tasks into your list.
    * **Delete:** Remove specific tasks by their index.
    * **List:** View all tasks in a clean, numbered format.
* **Input Validation:** Uses `int.TryParse` to ensure the application doesn't crash on invalid user inputs.
* **Persistent Loop:** An interactive menu that remains open until the user chooses to exit.

## 🛠️ Technical Stack

* **Language:** C#
* **Runtime:** .NET 8.0
* **Library:** `System.IO` for file management.

## 📋 Prerequisites

* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed on your machine.
* A terminal or command prompt.

## 🔧 Installation & Setup

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/JonathanManzanoDiaz/Task-Tracker-CLI.git](https://github.com/JonathanManzanoDiaz/Task-Tracker-CLI.git)
    ```

2.  **Navigate to the folder:**
    ```bash
    cd Task-Tracker-CLI
    ```

3.  **Run the application:**
    ```bash
    dotnet run
    ```

## 🎮 Menu Options

Once launched, navigate using the following options:

* **Press 1:** Add a new task (e.g., "Review pull requests").
* **Press 2:** Delete a task (you will be asked for the task number).
* **Press 3:** List all tasks saved in the system.
* **Press 0:** Exit the application.

## 📂 Project Structure

* `Program.cs`: Contains the main logic and menu system.
* `Tasks.json`: Local database where your tasks are stored (automatically created).
* `.gitignore`: Configured to exclude `bin/` and `obj/` folders to maintain a clean repository.

## 📌 Roadmap

- [ ] **Task Status:** Add support for `todo`, `in-progress`, and `done`.
- [ ] **Search:** Implement keyword search functionality.
- [ ] **Serialization:** Migrate to real JSON serialization using `System.Text.Json`.

---
© 2026 Jonathan Manzano Díaz