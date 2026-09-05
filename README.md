# DVLD - Driving & Vehicles Licensing Department

A desktop Driving License Management System built with **C#**, **.NET Framework**, **Windows Forms**, **ADO.NET**, and **Microsoft SQL Server**. The application manages people, users, driving license applications, tests, licenses, renewals, replacements, and related licensing workflows using a **3-Tier Architecture**.

## Features

### 👤 People & User Management

* Add, update, delete, and search people.
* Manage user accounts and user information.
* Manage user accounts, activation status, and login credentials.
* Reuse shared User Controls and components across the application.

### 📋 License Applications

* Manage driving license applications.
* Handle different application types.
* Manage new local driving license applications.
* Track application status and related information.

### 🪪 Driving Licenses

* Issue and manage driving licenses.
* Manage different license classes.
* Renew existing licenses.
* Replace lost or damaged licenses.
* Manage international driving licenses.
* Handle license detention and release workflows.

### 📝 Tests & Appointments

* Manage different driving test types.
* Schedule and manage test appointments.
* Record test results.
* Support the testing workflow required for driving license applications.

## Architecture

The application follows a **3-Tier Architecture** to separate responsibilities and improve maintainability:

```text
Presentation Layer
       ↓
Business Logic Layer
       ↓
Data Access Layer
       ↓
SQL Server Database
```

### Presentation Layer

Built with **C# Windows Forms**, responsible for:

* User interface
* User interaction
* Application screens
* Reusable User Controls

### Business Logic Layer

Contains the application's business rules and domain logic for:

* People
* Users
* Applications
* Drivers
* Licenses
* License classes
* Tests
* Test appointments
* International licenses
* License detention and release

### Data Access Layer

Uses **ADO.NET** to communicate with Microsoft SQL Server and provides data-access operations for the application's entities.

## Project Structure

The repository is organized into three main layers:

* `DVLD` — Presentation layer containing Windows Forms screens, User Controls, resources, and application configuration.
* `Business Logic` — Business and domain logic implemented through dedicated classes.
* `DataAccessLayer` — Database access classes using ADO.NET.
* `DVLD_DataSetup.sql` — SQL script for creating and configuring the required database and data.

### Main Business Logic Classes

Some of the main domain classes include:

* `clsPerson`
* `clsUser`
* `clsApplication`
* `clsApplicationTypes`
* `clsNewLocalDrivingLicenceApplication`
* `clsDrivers`
* `clsLicenses`
* `clsLicenceClass`
* `clsInternationalLicenses`
* `clsTests`
* `clsTestAppointments`
* `clsTestType`
* `clsDetainReleaseLicense`

## Tech Stack

* **Language:** C#
* **Framework:** .NET Framework
* **UI:** Windows Forms (WinForms)
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET
* **Database Scripting:** T-SQL
* **Architecture:** 3-Tier Architecture
* **IDE:** Visual Studio

## Getting Started

### Prerequisites

* Windows OS
* Visual Studio with .NET Framework and Windows Forms development support
* Microsoft SQL Server
* SQL Server Management Studio (SSMS)

### Running the Project

1. Clone the repository:

```bash
git clone https://github.com/Mohammed-3-6-9/DVLD.git
```

2. Open `DVLD.sln` in Visual Studio.

3. Open **SQL Server Management Studio** and execute:

```text
DVLD_DataSetup.sql
```

4. Configure the database connection in the application's `App.config` file if your SQL Server instance differs from the configured connection.

5. Build the solution in Visual Studio.

6. Run the **DVLD** project.

## Related Repository

A separate repository contains the ongoing refactoring and improvement of this project, focusing on code quality, maintainability, reusability, and cleaner design.

**DVLD-Refactoring:**
https://github.com/Mohammed-3-6-9/DVLD-Refactoring

## Author

**Mohammed Tawfiq**

[GitHub](https://github.com/Mohammed-3-6-9) | [LinkedIn](https://www.linkedin.com/in/mohammed-tawfiq1)
