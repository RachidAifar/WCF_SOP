# CRUD operations using C# and MySQL database
This is a simple application that demonstrates how to perform CRUD (Create, Read, Update, Delete) operations using C# Windows Communication Foundation (WCF) and MySQL database.

## Requirements

- Visual Studio
- MySQL Database Server
- MySQL Connector/NET

## Installation

1. Clone this repository to your local machine.
2. Open the solution file (`CRUDOperations.sln`) in Visual Studio.
3. Restore the NuGet packages.
4. Create a new MySQL database and execute the SQL script provided in the `database` folder.
5. Update the database connection string in the `web.config` file with your MySQL server and database credentials.

## Usage

1. Build and run the project.
2. The application exposes a WCF service that can be consumed by a client application.
3. Use the following methods to perform CRUD operations:
   - `Create`: Adds a new record to the database.
   - `Read`: Retrieves a record from the database based on a specified ID.
   - `Update`: Updates an existing record in the database.
   - `Delete`: Deletes a record from the database based on a specified ID.

## Contributing

Contributions are welcome! If you find any bugs or want to add new features, please feel free to create a pull request.

