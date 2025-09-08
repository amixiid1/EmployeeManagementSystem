Employee Management System

This project is an Employee Management System built with C# and SQL Server.
It provides basic CRUD functionality (Create, Read, Update, Delete) to manage employee records.

✨ Features

Add, view, update, and delete employees.

Store details such as: name, email, position, department, hire date, salary, etc.

Search and filter employees.

SQL Server database integration.

🛠 Technologies Used

C# (.NET Framework / .NET Core)

SQL Server / SQL Server Express

ADO.NET or Entity Framework Core (depending on your implementation)

Git / GitHub

⚡ Requirements

.NET SDK (e.g., .NET 6.0 or .NET Framework version you used)

SQL Server (or LocalDB / SQL Express)

Visual Studio or VS Code

🚀 Setup Instructions

Clone the repository

git clone https://github.com/<your-username>/<repo-name>.git
cd <repo-name>


Set up the Database
Run this SQL script in SQL Server Management Studio (SSMS) or Azure Data Studio:

CREATE DATABASE EmployeeDB;
GO

USE EmployeeDB;
GO

CREATE TABLE Employees (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(200),
    Position NVARCHAR(100),
    Department NVARCHAR(100),
    HireDate DATE,
    Salary DECIMAL(18,2),
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO Employees (FirstName, LastName, Email, Position, Department, HireDate, Salary)
VALUES
('Ahmed', 'Ali', 'ahmed.ali@example.com', 'Developer', 'IT', '2020-01-15', 60000),
('Fadumo', 'Mohamed', 'fadumo.m@example.com', 'HR Manager', 'HR', '2019-07-01', 75000);
GO


Update the connection string in appsettings.json or App.config:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=EmployeeDB;Trusted_Connection=True;"
  }
}

<connectionStrings>
  <add name="DefaultConnection" 
       connectionString="Server=.;Database=EmployeeDB;Trusted_Connection=True;" 
       providerName="System.Data.SqlClient" />
</connectionStrings>


Build & Run the project

Open in Visual Studio → Build → Run

Or via CLI:

dotnet build
dotnet run --project ./Path/To/YourProject.csproj

📖 Usage

When running the system, you can:

Add new employees

List all employees

Update employee details

Delete employees

Example menu (console app):

1) List employees
2) Add new employee
3) Update employee
4) Delete employee
5) Exit

✅ Best Practices

Always use parameterized queries or Entity Framework to avoid SQL Injection.

Do not hardcode database credentials inside code. Use environment variables or secrets.

Keep your code clean with meaningful names and comments.

🤝 Contributing

Fork the repo

Create a new branch (git checkout -b feature/my-feature)

Commit your changes

Push to your fork (git push origin feature/my-feature)

Create a Pull Request

📄 License

You can add a license (MIT, Apache 2.0, etc.) depending on your choice.

👤 Author

Name: mohamed jibriel

Email: amixiid@gmail.com

GitHub: amixiid1
