# TodoListDemo API

This is a simple RESTful API for managing a todo list, built with ASP.NET Core, Entity Framework Core, and MySQL.

## Features

- Create, read, update, and delete todo items  
- Each todo item has a Title, Description, and Completion status  
- Data persisted using EF Core with MySQL (Pomelo provider)  
- Unit tests implemented with NUnit and EF Core InMemory provider  

## Requirements

- .NET 7 SDK or newer  
- MySQL server (8.0+)  
- Visual Studio 2022 / VS Code or any IDE of your choice  

## Getting Started

1. Clone the repository:

```bash
git clone https://github.com/Carlings/TodoListDemo
cd TodoListDemo
```
2. Configure your MySQL connection string in appsettings.json:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3306;database=TodoListDb;user=root;password=your_password"
  }
}
```
3. Apply EF Core migrations to create the database schema:
```bash
dotnet ef database update
```
4. Run the API:
```bash
dotnet run
```

The API will be available at https://localhost:5001/api/todoitems

5. Running Unit Tests
Navigate to the test project folder and run:
```bash
dotnet test
```
Tests use EF Core InMemory provider for fast and isolated execution.

# Task Feedback
Please fill this section after completing each task:

Q: Was it easy to complete the task using AI?

A: Yes, AI provided very clear code snippets and explanations.

Q: How long did the task take you to complete?

A: About 1 hour, mostly debugging integration with MySQL.

Q: Was the code ready to run after generation? What did you have to change to make it usable?

A: The generated code worked mostly as-is, but I had to add the connection string and fix a small typo in the controller.

Q: Which challenges did you face during completion of the task?

A: Understanding how to properly configure EF Core migrations and seeding test data.

Q: Which specific prompts did you learn as good practice to complete the task?

A: Asking for “best practices to write unit tests for ASP.NET Core API with EF Core and MySQL” helped clarify test setup.