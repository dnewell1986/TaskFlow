# TaskFlow

TaskFlow is a task management application built with Blazor and .NET WebAPI. It allows users to create, search, edit, and delete tasks. The application provides a user-friendly interface for managing tasks efficiently.

## Features

-   Task Creation: Create tasks with a title, description, due date, and priority.
-   Task Listing: View a list of tasks with their details, including title, description, due date, priority, created by, and assigned to.
-   Task Editing: Edit the details of existing tasks, including title, description, due date, priority, created by, and assigned to.
-   Task Deletion: Delete tasks from the system.
-   User Management: Manage users associated with tasks as creators and assignees.
-   Search Functionality: Search for tasks based on different criteria such as title, due date, or priority.

## Technologies Used

-   Blazor: A framework for building interactive web UIs using C# and Razor syntax.
-   .NET WebAPI: A framework for building HTTP-based APIs using .NET and C#.
-   Entity Framework Core: A cross-platform ORM (Object-Relational Mapping) for .NET applications.
-   SQLite: A lightweight, file-based database engine for development and testing purposes.
-   Refit: A library for creating REST clients in .NET.

## Project Structure

The repository consists of the following projects:

-   `TaskFlow.UI`: Blazor front-end application.
-   `TaskFlow.WebAPI`: .NET WebAPI back-end application.
-   `TaskFlow.Shared`: Shared class library containing models, enums, and DTOs used by both front-end and back-end.

## Getting Started

To get started with TaskFlow, follow these steps:

1. Clone the repository:

    ```shell
    git clone https://github.com/your-username/taskflow.git
    ```

1. Build the solution using Visual Studio or the .Net CLI
    ```shell
    dotnet build
    ```
1. Set up the database:
    - Ensure you have SQLite installed on your machine.
    - Open a terminal or command prompt and navigate to the `TaskFlow.WebAPI` project directory.
    - Run the following command to apply the database migrations
        ```shell
        dotnet ef database update
        ```
1. Run the Blazor front-end and WebAPI back-end projects:
    - For the Blazor Server App (TaskFlow.UI):
        - Open the solution in Visual Studio
        - Set `TaskFlow.UI` as the startup project
        - Press F5 to run the application
    - For WebAPI (TaskFlow.WebAPI):
        - Open another terminal in the `TaskFlow.WebAPI` directory
        - Run the following command
            ```shell
            dotnet run
            ```

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
