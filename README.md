# RazorTemplate

This project aims at providing a minimal sample project with ASP.NET RazorPages.
It uses a containerized Postgres instance as its database and uses EntityFramework Core
for ORM (Object Relational Mapping), data schema definition, and migrations.
The template targets .NET 8.

## Setup
* [Install .NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* [Install the EntityFramework tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)
  * `dotnet tool install -g dotnet-ef` for global installation
  * `dotnet tool update -g dotnet-ef` for updating an existing install
* Install Docker

## Database Administration
To start just the database container, you can run 
`docker compose -f stack.dev.yml up`
Check the YAML definition for details like volumes, port mapping etc.

On a fresh DB we need to first apply the data model. The command for that:
`dotnet ef database update`
This applies the latest database migration.

To make changes to the data model:
* Change the DB code
  * Entities to change the tables
  * DbSet<> properties to add or remove tables
* Run `dotnet ef migration add <migration name>`. <migration_name> will give the migration a name.
  * Give it a descriptive name, similar to git commit messages.
* Apply the new migration
  * `dotnet ef database update`
  

## References
* EF Core overview: https://learn.microsoft.com/en-us/ef/core/
* Postgres with EF Core: https://jasonwatmore.com/post/2022/06/23/net-6-connect-to-postgresql-database-with-entity-framework-core