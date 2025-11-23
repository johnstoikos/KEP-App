# Citizen Request Management App (KEP)

## Overview
This project is a **Windows Forms application built in C# (.NET Framework)** for managing and recording **citizen requests** in a **Citizen Service Center (KEP)** environment.  
It enables employees to register, search, edit, and export citizen service requests.  
Data is stored locally in a **SQLite database**, ensuring portability and simplicity.

---

## Authors
- **Stoikos Ioannis Panagiotis** 
- **Anargyrou Lamprou Aikaterini**     

---

##  Key Features
 Register new citizen requests  
 Edit or delete existing entries  
 Search by keyword across multiple fields  
 Export requests as **TXT** or **PDF** files  
 Clean, responsive Windows Forms interface  
 Automatic database creation and initialization  

---

## Architecture Overview
The application follows an **MVC-like structure** for better organization and scalability:

| Layer | Purpose |
|--------|----------|
| **Model** | Represents data objects (citizen requests). |
| **Repository** | Handles all database operations. |
| **Database** | Centralizes connection string and access. |
| **UI (Form1)** | Provides user interface and event handling logic. |

---

## Components

### CitizenRequest.cs (Model)
Represents a **citizen request record** with the following properties:
- `Id`: Primary key (auto-incremented)
- `FullName`: Citizen’s full name  
- `Email`: Optional email address  
- `Phone`: Contact number  
- `BirthDate`: Date of birth (`DateTime`)  
- `RequestType`: Type of request (certificate, renewal, etc.)  
- `Address`: Home address  
- `RequestDate`: Date/time when the request was recorded  

> This class serves purely as a data container with no internal logic.

---

### RequestRepository.cs (Data Access Layer)
Handles all **CRUD operations** and communication with SQLite.

#### Key Methods
- **InitDatabase()** – Creates the `Requests` table if it doesn’t exist.  
- **Insert(CitizenRequest model)** – Adds a new record and returns its generated ID.  
- **Update(CitizenRequest model)** – Updates an existing record by `Id`.  
- **Delete(int id)** – Deletes a request by its primary key.  
- **GetAll()** – Returns a `DataTable` of all requests, ordered by `RequestDate DESC`.  
- **Search(string keyword)** – Performs case-insensitive search in `FullName`, `Email`, `Phone`, `Address`, and `RequestType`.

#### Database Notes
- Dates are stored as text (`TEXT`) in ISO format (`yyyy-MM-dd HH:mm:ss`) for compatibility.  
- The repository uses **parameterized queries** to prevent SQL injection.  

---

### Database.cs
Centralized management for database connections.

```csharp
private static readonly string connString = "Data Source=database.db;Version=3;";
public static SQLiteConnection GetConnection()
{
    return new SQLiteConnection(connString);
}
