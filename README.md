# DVLD
## DVLD - Driving & Vehicles Licensing Department

### 🚧 Status: Work In Progress
This project is currently under development as part of my learning journey to master Backend development and Desktop applications using C#.

### 📝 Project Overview
**DVLD** is a comprehensive system designed to manage driving licenses, applications, and tests. The main goal of this project is to implement a real-world business logic scenario using professional software engineering practices.

### 🏗️ Architecture & Technologies
The project follows a **3-Layer Architecture** to ensure clean code and separation of concerns:
* **Presentation Layer:** WinForms (C#) - Handling User Interface.
* **Business Logic Layer:** C# Class Library - Core logic and validation.
* **Data Access Layer:** C# Class Library (ADO.NET) - Database communication.
* **Database:** SQL Server.

### 🛠️ Technical Features Implemented
- **Decoupled Configuration:** Connection strings are managed via `App.config` for better flexibility and security.
- **Database Scalability:** Uses SQL scripts for easy deployment and database recreation.
- **Modular Design:** Each layer is independent, making it easier to switch to Web or Mobile in the future.

### 🚀 How to Setup
1. **Clone the repository:**
   ```bash
   git clone [https://github.com/Mohammed-3-6-9/DVLD.git]
Database Setup:
Open SQL Server Management Studio (SSMS).
Execute the DVLD_DataSetup.sql script found in the project root to build the database schema.

Connection:
The project is configured to use Windows Authentication.
Ensure your local SQL Server instance is running. You can modify settings in the App.config file within the DVLD (Presentation) project if needed.

Developed with ❤️ by Mohammed Tawfiq