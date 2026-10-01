# Hotel Management App

A Windows desktop application prototype built with C#, Windows Forms, and SQL Server. This project explores user login, account registration, and database-backed area records as a foundation for a hotel management application.

## Project Status

Work in progress. The repository contains the desktop interface and initial database integration. Registration and area-search workflows require fixes, and a database creation script is not included. Room reservations, guest check-in/check-out, and payment management are not implemented yet.

## Current Components

- **Login:** Checks usernames and passwords against the SQL Server `Users` table.
- **Password visibility:** Allows users to show or hide their password on the login screen.
- **Registration form:** Collects username, full name, password confirmation, gender, birth date, and family count, with a terms acceptance checkbox. The submission logic needs correction.
- **Main interface:** Includes a tabbed layout, a data grid, search controls, and logout/exit buttons.
- **Area records:** Initial queries target an `Area` table. Data loading and search are incomplete.

## Technology Stack

| Technology | Purpose |
| --- | --- |
| C# | Application logic |
| Windows Forms | Desktop user interface |
| .NET Framework 4.7.2 | Application framework |
| SQL Server / SQL Server Express | Database |
| ADO.NET (`System.Data.SqlClient`) | Database access |

## Getting Started

### Requirements

- Windows
- Visual Studio with the **.NET desktop development** workload
- .NET Framework 4.7.2 targeting pack
- SQL Server or SQL Server Express
- SQL Server Management Studio (optional, for database setup)

### 1. Clone the repository

```bash
git clone https://github.com/Stewiecancode/HOTEL-MANAGEMENT-APP.git
cd HOTEL-MANAGEMENT-APP
```

### 2. Open the solution

Open `session 4 coding.sln` in Visual Studio.

### 3. Configure the database

The repository does not include a database schema, backup, or seed data. You must supply a compatible database before using the database-dependent features.

The code references:

- A database named `DataBase`.
- A `Users` table with references to `GUID`, `UserTypeID`, `Username`, `Password`, `FullName`, `Gender`, `BirthDate`, and `FamilyCount`.
- An `Area` table with a `Name` column used in search.

Column types, constraints, and the complete `Area` schema are not documented in the repository.

Update the `connectionstring` field in `Form1.cs`, `Form2.cs`, and `Form3.cs` to match your SQL Server instance. For example:

```csharp
string connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataBase;Integrated Security=True";
```

This example uses Windows Authentication. Your Windows account must have permission to access the database.

### 4. Build and launch

Select **Build > Build Solution**, then press **F5** to launch the application. A successful build does not resolve the incomplete database workflows described below.

## Known Limitations

- The registration query lists eight columns but supplies six values, so it needs correction before registration can work.
- Password and terms validation need correction and should happen before saving data.
- Area loading and search have incomplete command/adapter configuration.
- Connection strings and the terms-file path are hard-coded for the original development machine.
- The login query compares passwords directly; password hashing is not implemented.
- Logout opens a login window but leaves the main form visible.

## Planned Improvements

- Add a database setup script and sample data.
- Fix registration, validation, search, and logout behavior.
- Centralize database configuration.
- Use parameterized queries consistently and implement password hashing.
- Add room management, reservations, guest check-in/check-out, and payment tracking.
- Improve interface labels, error handling, and documentation.

## Author

**Tshireletso Selemela**  
GitHub: [@Stewiecancode](https://github.com/Stewiecancode)

## License

No license file is currently included in this repository.
