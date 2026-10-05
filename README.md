# Message Board
A simple C# console application that allows users to create and manage posts on a shared message board.

## Features
* Log in using a username and password
* View posts from all users
* Create new posts
* Edit your own posts
* Simple console-based interface

## Test Login Details
This project uses **pre-created test users** for demonstration purposes. No real personal information is used.
The project includes example accounts and posts so the application can be tested immediately.

## Data Files
The application uses local text files to store user accounts and message board posts.
The `UserInformation.txt` and `posts.txt` files are required for the application to run and are included in the repository.

**Important:** The files should be located at:
`bin > Debug > net10.0-windows`
The usernames, passwords and posts included in these files are fictional and were created specifically for this project.

## Running the Application
1. Clone or download this repository.
2. Open the `.sln` or `.csproj` file in Visual Studio.
3. Build the solution.
4. Make sure `UserInformation.txt` and `posts.txt` are located in `bin > Debug > net10.0-windows`.
5. Run the application.
6. Use one of the test accounts provided in `UserInformation.txt` to log in.

The `obj` and `.vs` folders are not included in the repository because Visual Studio generates these files automatically.

## Technologies
* C#
* .NET
* Visual Studio
* File-based data storage

## Purpose
This project demonstrates my understanding of:
* C# programming
* File handling
* User authentication
* CRUD-style operations
* Collections and data management
* Console application development
* Input validation and user interaction
