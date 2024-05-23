Here's a `README.md` file for your project:

---

# JustDoIT - To-Do List Application

JustDoIT is a simple and lightweight to-do list application built with C# and .NET Framework. It provides basic functionality to create, update, delete, and save to-do items. The user interface is designed using MaterialSkin for a modern and clean look.

## Features

- **Add New To-Do Items**: Quickly add new tasks with a title and description.
- **Edit Existing Items**: Modify the details of your existing tasks.
- **Delete Items**: Remove tasks that are no longer needed.
- **Save Items**: Save new tasks or updates to existing tasks.

## Screenshot

![To Do List 5_24_2024 1_00_51 AM](https://github.com/MahdiNoorzadeh/JustDoIT/assets/120558263/9d6c3f8a-226d-40cc-a265-8f3c560a3f69)

## Getting Started

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/MahdiNoorzadeh/JustDoIT
   ```
2. Open the solution file (`JustDoIT.sln`) in Visual Studio.

3. Restore NuGet packages:
   - Open the NuGet Package Manager Console (Tools > NuGet Package Manager > Package Manager Console).
   - Run the following command:
     ```bash
     Install-Package MaterialSkin.2
     ```

4. Build and run the project.

## Usage

1. **Add New Items**:
   - Click on the "New" button to clear the text fields.
   - Enter the title and description of your new task.
   - Click on the "Save" button to add the task to the list.

2. **Edit Items**:
   - Select an existing task from the data grid.
   - Click on the "Edit" button to load the task details into the text fields.
   - Modify the details and click on the "Save" button to update the task.

3. **Delete Items**:
   - Select the task you want to remove from the data grid.
   - Click on the "Delete" button to remove the task from the list.

## Code Overview

The main logic of the application is implemented in the `FrmToDo` class:

- **Form Initialization**: Initialize the form and set up event handlers.
- **Click Events**: Handle the click events to clear placeholder text in the text boxes.
- **CRUD Operations**: Implement the Create, Read, Update, and Delete functionality using a DataTable as the data source.

## Contributing

If you would like to contribute to this project, please fork the repository and submit a pull request. I welcome any contributions that improve the application.

## License

This project is licensed under the GPL-3.0 License - see the [LICENSE](https://github.com/MahdiNoorzadeh/JustDoIT#GPL-3.0-1-ov-file) file for details.

---
