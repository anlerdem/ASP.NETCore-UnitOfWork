# C# - ASP.NET Core MVC - Simple CRUD Example Application with Repository, Dependency Injection and Unit of Work Pattern

About the application technologies and operation:

### Technologies:
- Programming Language: C#
- Front-End Side: ASP.NET MVC - .NET Core 7
- Back-End Side: .NET Core 7
- Descriptive Language: HTML
- Style Description Language: CSS (Bootstrap)
- Database: MSSQL (Code First Database Migration)

### Application solution structure:
- **CRUDExample**: 
    - Includes the FrontEnd Side of the application.
    - Includes IoC DI Registers, with separate configuration files.
    - Includes Middlewares.
- **DataLayer**:
    - Includes the Database Context.
    - Includes the Database Entities.
- **ApplicationCore**:
    - Includes classes and interfaces required for Repository Pattern.
    - Includes classes and interfaces required for Unity of Work.
    - Includes classes and interfaces required for BackEndException Handler.
