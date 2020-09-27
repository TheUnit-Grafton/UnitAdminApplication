## MySQL Test Data instructions:

This folder contains a SQL dump of the test database used by this application. To set up a local development copy of the database will require MySQL Server (or XAMPP or similar).

The .SQL file is a complete dump of the application database.  it does __NOT__ include the seperate database for authentication.

You can use phpMyAdmin, MySQL Workbench, or the MySQL CLI to create the database.

The user authentication database is deliberately seperate from the main database.  This application uses the Microsoft Identity framework, and hence Entity Framework Core.  To generate the database, an EF Migration needs to be run.

To create the user database, run the following command from the Package Manager Console in Visual Studio.  You may also use the .net core CLI, but the command will be different.

```
PM> Update-Database -c AuthDbContext
```

Modify the two connection strings in the appsettings.json file, and you should be up and running.