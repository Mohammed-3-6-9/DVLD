# DVLD - Driving & Vehicles Licensing Department

## 📌 Project Overview

**DVLD** is a desktop application designed to manage people, users, driving license applications, tests, licenses, renewals, replacements, and license status.

The project simulates a real-world driving license management system and focuses on implementing business logic using a structured and maintainable software architecture.

## 🏗️ Architecture

The application follows a **3-Tier Architecture** to separate responsibilities and improve maintainability:

* **Presentation Layer:** C# Windows Forms — Handles the user interface and user interactions.
* **Business Logic Layer:** C# Class Library — Contains business rules, validation, and application logic.
* **Data Access Layer:** C# Class Library using ADO.NET — Handles communication with the database.
* **Database:** Microsoft SQL Server

## 🛠️ Technologies

* C#
* .NET Framework
* Windows Forms
* ADO.NET
* Microsoft SQL Server
* T-SQL

## ✨ Key Features

* Manage people and users.
* Manage driving license applications.
* Manage different types of driving tests.
* Issue and manage driving licenses.
* Renew and replace licenses.
* Manage license status and related workflows.
* Implement reusable User Controls and shared components.
* Maintain separation of concerns through a 3-Tier Architecture.
* Use SQL Server to manage relational data and interconnected entities.

## ⚙️ Technical Highlights

* **Layered Architecture:** Separates Presentation, Business Logic, and Data Access responsibilities.
* **Reusable Components:** Uses shared User Controls and components to improve code reuse and maintainability.
* **Database Integration:** Uses ADO.NET for database communication with SQL Server.
* **Configuration:** Connection settings are managed through `App.config`.
* **Database Setup:** Includes SQL scripts to recreate and configure the required database.

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/Mohammed-3-6-9/DVLD.git
```

### 2. Setup the Database

Open **SQL Server Management Studio (SSMS)** and execute the `DVLD_DataSetup.sql` script located in the project root.

### 3. Configure the Connection

The application uses **Windows Authentication** by default.

If necessary, update the connection string in the `App.config` file of the Presentation project to match your local SQL Server instance.

### 4. Run the Application

Open the solution in **Visual Studio**, build the solution, and run the Presentation project.

## 📚 Related Repository

A separate repository contains the ongoing **refactoring and improvement** of this project, focusing on code quality, maintainability, reusability, and cleaner design.

**DVLD-Refactoring:**
https://github.com/Mohammed-3-6-9/DVLD-Refactoring

---

Developed by **Mohammed Tawfiq**
