# Dental Clinic Information System

A desktop application built in VB.NET to manage a dental clinic, including patient records, appointments, and billing. This application connects to a MySQL database, which must be set up before running the application.

## Table of Contents
- [Prerequisites](#prerequisites)
- [Database Setup](#database-setup)
- [MySQL Connection Configuration](#mysql-connection-configuration)
- [Running the Application](#running-the-application)
- [Troubleshooting](#troubleshooting)

## Prerequisites
- **Visual Studio**: Install [Visual Studio](https://visualstudio.microsoft.com/) with VB.NET support.
- **MySQL Server**: Install [MySQL Server](https://dev.mysql.com/downloads/mysql/) to host the database.
- **MySQL Workbench** (optional): For managing and visualizing the database.

## Database Setup
1. **Locate the MySQL dump file**: The MySQL dump file, `Dental_Clinic_Database_Structure.sql`, is in the `MySql Dump` folder of the project.
2. **Import the database**:
   - Open **MySQL Workbench** or your preferred MySQL client.
   - Create a new database (e.g., `clinic_tooth`).
   - Go to **Server > Data Import** or use the `mysql` command-line tool to import the dump file:
     ```bash
     mysql -u username -p clinic_tooth < path/to/MySql Dump/Dental_Clinic_Database_Structure.sql
     ```
   - Replace `username` with your MySQL username.

## MySQL Connection Configuration
The connection setup is managed by the `DatabaseManager` class in `Module2.vb`. You need to ensure that the connection string matches your MySQL configuration.

1. Open `Module2.vb` located in the `Modules` folder.
2. Verify or update the connection string in the `DatabaseManager` class:
   ```vbnet
   Private Shared connectionString As String = "Server=127.0.0.1;Port=3307;Database=clinic_tooth;User=root;Password=password123"