# GreenShopStore

A robust, green-themed e-commerce web application built using **ASP.NET Core 8.0 MVC**. The project is designed with a multi-area architecture (Admin, Customer, Identity) and relies on Entity Framework Core with SQL Server for data management.

## Project Architecture & Features

The application follows the **MVC (Model-View-Controller)** design pattern and uses **Areas** to logically separate the application into distinct modules:

- **Customer Area**: The public-facing shop interface where users can browse products, view categories, see the gallery, and use the contact form.
- **Admin Area**: The backend dashboard for administrators to manage products, categories, gallery images, and user inquiries.
- **Identity Area**: Manages user authentication, registration, login, and account management using ASP.NET Core Identity.

### Core Domain Models
- `Product`: Represents the items sold in the store.
- `Category`: Used to group products.
- `Galeri`: Manages the image gallery.
- `Contact`: Handles user messages and inquiries.
- `AppUser`: Extends the default `IdentityUser` for custom user properties.

## Technologies Used

### Backend
- **Framework**: .NET 8.0 (ASP.NET Core MVC)
- **Language**: C# 12
- **ORM**: Entity Framework Core 8.0.11
- **Database**: Microsoft SQL Server
- **Authentication & Authorization**: ASP.NET Core Identity (`Microsoft.AspNetCore.Identity.UI`)

### Frontend
- **CSS Framework**: Bootstrap 5 (Customized via SCSS)
- **JavaScript Libraries**: 
  - jQuery
  - OwlCarousel (for interactive image/product sliders)
  - WOW.js & Animate.css (for scroll animations)
  - Waypoints (for triggering actions based on scroll position)
- **UI Architecture**: Razor Views (`.cshtml`)

## Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- SQL Server (LocalDB or full instance)
- Visual Studio 2022 (recommended) or VS Code.

## Installation & Setup

1. **Clone the repository:**
   ```bash
   git clone https://github.com/semihgny/GreenShopStore.git
   cd GreenShopStore
   ```

2. **Database Configuration:**
   Open `appsettings.json` and update the `DefaultConnection` string to point to your local SQL Server instance. The default is set to:
   ```json
   "Server=LAB3-00;Database=proje;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
   ```
   *Change `LAB3-00` and `proje` to your SQL Server name and desired database name.*

3. **Apply Migrations:**
   Open the Package Manager Console in Visual Studio and run:
   ```powershell
   Update-Database
   ```
   *Or via .NET CLI:*
   ```bash
   dotnet ef database update
   ```

4. **Build and Run:**
   - In Visual Studio, simply press `F5` or click **Start**.
   - Via CLI, run:
     ```bash
     dotnet run
     ```
   The application will be hosted locally (typically at `https://localhost:5001` or similar).

## License
This project is open-source. Please see the repository for more details on usage rights.
