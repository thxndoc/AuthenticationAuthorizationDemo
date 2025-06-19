# Authentication and Authorization Demo - Simple ASP.NET Core MVC Authentication & Authorization

This is a simple example project built with **ASP.NET Core MVC** demonstrating basic **authentication and authorization** with two different user roles: **Admin** and **User**. Depending on the role, users are redirected to different dashboards after logging in.

---

## Features

- Login page with username and password
- Role-based authorization for Admin and User
- Two different dashboard views:
  - Admin Dashboard (`/Dashboard/Admin`)
  - User Dashboard (`/Dashboard/User`)
- Cookie-based authentication
- Logout functionality

---

## Technologies Used

- ASP.NET Core MVC (.NET 6 or 7)
- Razor Views (`.cshtml`)
- Cookie Authentication
- Visual Studio 2022

---

## How to Run

1. **Clone the repository and open project in Visual Studio:**

   ```PowerShell
   git clone https://github.com/thxndoc/AuthDemo.git
   cd AuthDemo
   ```
   
2. **Run the project**
- press F5 or select 'Run'

3. **Enter credentials:**
- username for Admin is **admin** & password is admin **admin123**
- username for User is **user** & password is admin **user123**

