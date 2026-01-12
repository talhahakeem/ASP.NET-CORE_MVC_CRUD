ASP.NET-CORE_MVC_CRUD

A robust ASP.NET Core 8 MVC CRUD application that demonstrates full Create, Read, Update, and Delete functionality using Entity Framework Core with either database-first or code-first approaches.

This project is built following MVC architecture principles and shows how to manage and interact with data in a real-world web application.

🚀 Features

✔ Full CRUD operations (Create, Read, Update, Delete)
✔ Built with ASP.NET Core MVC
✔ Uses Entity Framework Core for data access
✔ Database-first and Code-first support
✔ Simple and clean UI for managing records

📦 Technologies Used
Technology	Purpose
ASP.NET Core MVC	Web framework
Entity Framework Core	ORM for database operations
C#	Application language
SQL Server	Relational database
Razor Views	UI Templates
🧠 Architecture

This project follows the MVC (Model-View-Controller) pattern:

Models – Represent application data structures

Views – UI pages (HTML + Razor syntax)

Controllers – Handle user requests and orchestrate data interaction

This separation improves maintainability and clarity in code structure.

📥 Getting Started
1. Clone the repository
git clone https://github.com/talhahakeem/ASP.NET-CORE_MVC_CRUD.git
cd ASP.NET-CORE_MVC_CRUD

2. Open in Visual Studio

Open the solution (.sln) file in Visual Studio 2022+ (or VS Code with the .NET extension).

3. Configure your database

Update the connection string in appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=True;"
}

4. Apply Migrations & Create Database

If using Code-First:

dotnet ef migrations add InitialCreate
dotnet ef database update


If using Database-First, ensure your database exists and models match.

5. Run the App

Use Visual Studio or CLI:

dotnet run


Then browse to:

https://localhost:5001

📁 Typical Project Structure
/Controllers     – Web controllers  
/Models          – Data models  
/Views           – View pages  
/Data            – DbContext and database configuration  
/wwwroot         – Static files (CSS, JS)  

🧪 Usage

✔ Browse records
✔ Add new entries
✔ Edit existing entries
✔ Delete items

This UI flows through standard MVC routes and form submissions to perform database operations.

📌 Contributing

If you’d like to improve this project:

Fork the repo

Create a new branch

Make your improvements

Submit a Pull Request

📝 License

This project is open-source and available under the MIT License.

📫 Contact

For feedback or questions, you can open an issue on GitHub or reach out via your preferred contact method.
