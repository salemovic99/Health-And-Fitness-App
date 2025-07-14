# Health-And-Fitness-App 🏋️‍♀️

A comprehensive Health and Fitness web application built using ASP.NET Core MVC. This app allows users to manage workouts, track progress, and access health-related content in a user-friendly environment.

---

## 📌 Features

- 🧍 User registration and authentication  
- 📝 Daily workout logging  
- 📊 Progress tracking  
- 🥗 Nutrition tips and plans  
- 📅 Calendar view of workouts  
- 🔍 Admin panel to manage content  

---

## 🔧 Tech Stack

- **Frontend**: Razor Views, HTML, CSS  
- **Backend**: ASP.NET Core MVC  
- **Database**: Entity Framework Core with SQL Server  
- **Authentication**: ASP.NET Identity  
- **Other Tools**: LINQ, Dependency Injection, Configuration via `appsettings.json`

---

## 📁 Project Structure

## Health-And-Fitness-App/
│
├── Controllers/ # MVC Controllers (Home, User, Workout, etc.)
├── Models/ # Data models (User, Exercise, MealPlan, etc.)
├── Views/ # Razor views (.cshtml files)
├── Data/ # Database context
├── Migrations/ # EF Core migration files
├── wwwroot/ # Static assets (CSS, JS, images)
├── Program.cs # App startup entry point
├── appsettings.json # App configuration
└── README.md # Project documentation


---

## 🚀 Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [SQL Server or LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
- [Visual Studio](https://visualstudio.microsoft.com/) (Recommended)

### Setup Instructions

1. **Clone the repo**
   ```bash
   git clone https://github.com/salemovic99/Health-And-Fitness-App.git
   cd Health-And-Fitness-App
1 **Restore NuGet packages**

 dotnet restore

2 **Update the database**

 dotnet ef database update

3 **Run the project**

dotnet run
