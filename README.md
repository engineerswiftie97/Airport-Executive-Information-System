# Airport Executive Information System

**A C# Windows Forms desktop application for viewing and reporting airport operational information.**

This project was developed as a Computer Engineering graduation project at **Maltepe University**. It brings several airport management areas into one interface so that executives and managers can select a department, filter the available information, and view reports without switching between separate systems.

> **Academic prototype:** The application uses a sample Microsoft SQL Server database rather than live airport data. Its camera-related screens play prerecorded video, not live CCTV feeds. It is not intended for operational deployment at an airport.

## Project Overview

Airports have many interconnected operations, from air traffic control and aircraft parking to staffing, technical maintenance, and security. The **Airport Executive Information System** explores how a centralized desktop interface can help management access relevant information efficiently.

The project uses **Istanbul Airport as an example setting**, but its concept is not tied to a specific airport.

## Features

The application organizes information into six main areas:

| Module | Information and interactions |
| --- | --- |
| **Airline Companies & Information** | Select an airline and date; choose report fields and view company-related information. |
| **Air Traffic Control** | Select air traffic control offices and terminal-related information; view departmental reports. |
| **Runways & Aprons** | Look up runway, gate, and apron information, including apron availability; access associated video views. |
| **Employees on Duty** | Search employee records using identifying information, work area, and dates; view available employee details. |
| **Technical Units** | Select a technical unit and inspect maintenance-related information and reports. |
| **Car Park & Security** | Access car park and passport-control information, filter reports, and view associated prerecorded footage. |

Other interface capabilities include form-based navigation, text fields, checkboxes, drop-down selections, date pickers, and report results displayed in **DataGridView** controls.

## Tech Stack

- **Language:** C#
- **Desktop UI:** Windows Forms
- **Development environment:** Microsoft Visual Studio
- **Database:** Microsoft SQL Server
- **Data access:** SQL queries integrated with the Windows Forms application

## How It Works

1. The user opens the main Windows Forms screen and selects an airport operations module.
2. The relevant form allows them to enter search terms, choose dates, or select report fields.
3. The application queries its Microsoft SQL Server database for the matching sample records.
4. Results are displayed in a `DataGridView` or the relevant report screen.
5. Where video viewing is available, the application displays locally sourced prerecorded media.

### Architecture

The project follows a form-based desktop application structure:

```text
Executive / Manager
        |
        v
Windows Forms Main Menu
        |
        v
Department-Specific Forms
        |
        v
SQL Queries <----> Microsoft SQL Server
        |
        v
Reports / DataGridView / Media Views
```

The report also describes using a **Singleton pattern** to manage a database instance. The sample database was structured around the individual forms, with a limited set of relationships between tables.

## Running the Project

The application targets Windows and was developed using Visual Studio and SQL Server. To run the project from source:

1. Open the Windows Forms solution (`.sln`) in a compatible version of **Visual Studio**.
2. Make sure the necessary **.NET / Windows Forms development components** are installed for the framework version used by the solution.
3. Set up **Microsoft SQL Server** and restore or create the sample database from the database files or scripts included in this repository, **if provided**.
4. Update the application's database connection settings to point to your SQL Server instance.
5. Build and run the application from Visual Studio.

**Note:** The original project report does not specify the exact .NET Framework version, connection-string location, database setup scripts, or startup configuration. Consult the repository source files for those details. If the sample database is not included, database-backed features will require additional setup.

## Scope and Limitations

This is a graduation-project prototype, not a production airport management solution.

- **Sample data:** No real airport operational database was available, so the database contains manually prepared example records.
- **Limited date coverage:** Reports are available for only some dates in the sample dataset.
- **Prerecorded video:** Security and camera-related views use downloaded video files rather than connected live cameras.
- **Database design:** Tables are primarily organized by form, with limited relational links.
- **Security:** Further authentication, access controls, and security improvements would be needed for real-world use. A login screen was described as a future enhancement in the report.

## Possible Future Improvements

- Implement authentication and role-based access control.
- Expand and normalize the relational database.
- Connect to authorized real-time airport information sources.
- Replace prerecorded media with properly secured live camera integrations.
- Improve reporting, filtering, and data coverage.
- Refactor the codebase into a more modular, maintainable architecture.
- Explore a web-based or mobile version of the application.

## Academic Information

- **Project:** Airport Executive Information System
- **Author:** Melisa Akbaydar
- **Department:** Computer Engineering, Faculty of Engineering and Natural Sciences
- **University:** Maltepe University
- **Project advisor:** Prof. Dr. Ceren Çubukçu
