

# KanbanApp

A **Blazor WebAssembly Kanban Board Application** for task management. This application allows users to create, update, delete, and organize tasks into columns like **To Do**, **In Progress**, and **Done**, all stored locally in the browser using Blazored.LocalStorage.

---

## Table of Contents

1. [Features](#features)
2. [Demo](#demo)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Project Structure](#project-structure)
6. [Technologies](#technologies)
7. [Contributing](#contributing)
8. [License](#license)

---

## Features

* Add, edit, and delete tasks.
* Drag and drop tasks between columns.
* Persistent storage in browser using **Blazored.LocalStorage**.
* Real-time UI updates with **state notifications**.
* Responsive UI with Bootstrap styling.
* Optional PWA support (can be disabled for development).

---

## Demo

![KanbanApp Screenshot](screenshot.png)

> Screenshot placeholder – replace with your actual screenshot showing the Kanban board interface.

---

## Installation

1. **Clone the repository**

```bash
git clone https://github.com/yourusername/KanbanApp.git
cd KanbanApp
```

2. **Ensure you have .NET 8 SDK installed** (Preview versions may work).

3. **Restore dependencies**

```bash
dotnet restore
```

4. **Run the application**

```bash
dotnet run
```

5. **Open in browser**
   Navigate to [https://localhost:7135](https://localhost:7135) (or the port your app uses).

> **Note:** You may need to bypass SSL warnings in development.

---

## Usage

* Click **Add Task** to create a new task.
* Drag tasks between columns to change their status.
* Click a task to **edit** or **delete** it.
* Tasks are automatically saved to your browser’s local storage.

---

## Project Structure

```
KanbanApp/
│
├─ wwwroot/                # Static files (CSS, JS, icons)
├─ Pages/                  # Blazor pages (Index.razor, Home.razor, etc.)
├─ Services/               # TaskService.cs
├─ Models/                 # KanbanTask.cs, ColumnType.cs
├─ Program.cs              # Application entry point
├─ App.razor               # Root component
├─ Index.html              # Main HTML template
└─ KanbanApp.csproj        # Project file
```

---

## Technologies

* **.NET 8 Blazor WebAssembly**
* **C#**
* **Bootstrap 5**
* **Blazored.LocalStorage** for persistent task storage

---

## Contributing

1. Fork the repository.
2. Create a new branch: `git checkout -b feature-name`
3. Make your changes.
4. Commit your changes: `git commit -m "Description of changes"`
5. Push to the branch: `git push origin feature-name`
6. Open a Pull Request.

---

## License

This project is **open-source**. You can use and modify it freely.


