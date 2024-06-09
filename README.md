# Dotnet BackgroundService with MediatR Example

This project demonstrates a focused proof of concept on integrating `BackgroundService` in a .NET application to invoke a command handler through the `MediatR` library's `ISender.Send` method. The goal is to showcase how background tasks can be managed and executed within a .NET application, leveraging the MediatR library for clean and decoupled architecture.

## Features

- **Background Processing**: Utilizes the `BackgroundService` class to implement long-running background tasks.
- **Command Handling**: Demonstrates the use of MediatR for handling commands, making the codebase more maintainable and decoupled.
- **Dependency Injection**: Showcases the integration of MediatR with .NET Core's built-in dependency injection system.


