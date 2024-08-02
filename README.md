# Purchase Tracker Web Application

This is a web application built using ASP.NET MVC with Entity Framework that allows users to track their purchases. The application includes all CRUD (Create, Read, Update, Delete) functions for managing purchase records.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Features
- **Create**: Add new purchase records.
- **Read**: View a list of all purchases.
- **Update**: Edit existing purchase records.
- **Delete**: Remove purchase records.
- **Responsive Design**: The application is designed to work well on both desktop and mobile devices.

## Technologies Used
- ASP.NET MVC
- Entity Framework
- SQL Server
- HTML/CSS
- Bootstrap

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) (recommended) or any code editor

### Installation
1. **Clone the repository**:
   ```sh
   git clone https://github.com/yourusername/purchase-tracker.git
   cd purchase-tracker
   ```

2. **Restore dependencies**:
   ```sh
   dotnet restore
   ```

3. **Update the database connection string**:
   - Open `appsettings.json`.
   - Update the `DefaultConnection` string to match your SQL Server configuration.

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=your_server;Database=your_database;Trusted_Connection=True;"
     }
   }
   ```

4. **Apply migrations and create the database**:
   ```sh
   dotnet ef database update
   ```

5. **Run the application**:
   ```sh
   dotnet run
   ```

6. Open your browser and navigate to `https://localhost:5001` (or the URL provided in the console output).

## Usage
- **Home Page**: Displays a SUM of all the purchases.
- **Add Purchase**: Navigate to the "Add Purchase" page to create a new purchase record.
- **Edit Purchase**: Click the "Edit" button next to a purchase to update its details.
- **Delete Purchase**: Click the "Delete" button next to a purchase to remove it from the list.
