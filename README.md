# ProJECt AD 202 – Student Application System

📌 Project Overview
ProJECt AD 202 is a Windows Forms Application developed using C# and .NET Framework.
The project allows users to capture and store student information in a SQL Server database.

The application provides a simple form where a student’s personal details can be entered and submitted.
Once submitted, the data is saved directly into a database for future use.

---

## 🎯 What the Project Does

The system allows users to:

* Enter student details such as:

  * Name
  * Surname
  * Age
  * Gender
  * Address
  * Course
* Submit the information to a SQL Server database
* Clear the form using a reset button
* Receive confirmation messages after successful submission
* Handle errors if fields are left empty or if a database issue occurs

---

## 🛠️ Technologies Used

* C#
* Windows Forms
* .NET Framework
* SQL Server (SQLEXPRESS)
* ADO.NET (`SqlConnection` & `SqlCommand`)
* Visual Studio

---

## 💡 Why This Project Is Useful

* Demonstrates basic CRUD concepts (Create operation) using C# and SQL Server
* Helps students understand database connectivity using ADO.NET
* Shows how to validate user input in a desktop application
* Demonstrates parameterized SQL queries
* Improves understanding of event-driven programming
* Useful for learning real-world application development, especially for academic projects

---

## 🚀 Possible Future Improvements

* Add data viewing functionality
* Add update and delete functionality
* Improve error messages
* Add login and user roles
* Use combo boxes for gender and course selection
* Add advanced form validation
* Replace hard-coded connection string with configuration-based settings
* Add search functionality for students

---

## ▶️ Installation and Setup Instructions

### Requirements

Before running the application, make sure you have the following installed:

* Visual Studio
* .NET Framework
* SQL Server Express
* SQL Server Management Studio (SSMS)

---

## ⚙️ Database Setup

1. Open SQL Server Management Studio.
2. Create a database named:

```sql id="gw0o7j"
StudentDatabase
```

3. Run the following SQL script to create the student table:

```sql id="okyxae"
CREATE TABLE student
(
    StdName VARCHAR(50),
    StdSurname VARCHAR(50),
    Age VARCHAR(10),
    Gender VARCHAR(20),
    Address VARCHAR(100),
    Course VARCHAR(100)
);
```

4. Ensure your SQL Server instance name matches the connection string used in the application:

```csharp id="1ud4r5"
Data Source=YK-LAPTOP/SQLEXPRESS;
Initial Catalog=StudentDatabase;
Integrated Security=True
```

5. If your SQL Server name is different, update the connection string inside `Form1.cs`.

---

## ▶️ Steps to Run the Application

1. Download or extract the project ZIP file.
2. Open the solution file in Visual Studio.
3. Restore project dependencies if prompted.
4. Build the solution using:

```bash id="6h4gnp"
Ctrl + Shift + B
```

5. Run the application by pressing:

```bash id="xvx5qx"
F5
```

6. Enter student details into the form.
7. Click the Submit button to save the information into the database.
8. Click the Reset button to clear all input fields.

---

## 📚 Educational Value

This project is ideal for:

* Application Development students
* Beginners learning C# Windows Forms
* Understanding how front-end forms interact with databases
* Practicing structured and event-driven programming
* Learning database connectivity with ADO.NET
* Understanding form validation and SQL operations

---

Author: Linamandla Sobikela
Project Type: Academic / Learning Project
