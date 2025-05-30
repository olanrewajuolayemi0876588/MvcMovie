2025-05-26	
Initialized ASP.NET Core MVC project (MvcMovie)	09:30 AM
Created a new ASP.NET Core MVC web app project	10:00 AM
Added a Controller and View for the "Hello World" test route	10:45 AM
Added Razor syntax and passed data from controller to view	12:00 PM
Created the Movie model and used scaffolding with EF Core	02:00 PM
Resolved duplicate 'Index' error due to re-scaffolding of MoviesController	02:30 PM
Added Search/Filter functionality to Movie Index page	04:00 PM
Added a new field Rating to Movie model and regenerated views	08:30 AM
Ran EF Core commands: Add-Migration Rating and Update-Database 20250527015730_Rating	09:00 AM
Verified database changes via SQL Server Object Explorer	09:30 AM
Updated SeedData.cs to include Rating and ensured seeding worked correctly	10:00 AM
Used Data Annotations for validation in the Movie model	10:30 AM
Added a new field using EF Core migration + updated views	11:30 AM
Reviewed the entire project, validated DB and seed data	12:00 PM

# MvcMovie ASP.NET Core MVC App

## Overview
This project is a full implementation of the ASP.NET Core MVC tutorial. 

It includes CRUD functionality, database seeding, and Azure deployment.

## Features
- ASP.NET Core MVC architecture
- Entity Framework Core + SQLite
- CRUD operations for movies
- Seeded database with 5+ movies

## Seeded Movies
- Inception (2010)
- The Matrix (1999)
- Interstellar (2014)
- Parasite (2019)
- Spirited Away (2001)

## ISO 8601 Timestamps
- Project Started: 2025-05-27T14:00:00Z  
- Project Completed: 2025-05-30T20:45:00Z

## How to Run Locally
```bash
git clone https://github.com/olanrewajuolayemi0876588/MvcMovie
cd MvcMovie
dotnet restore
dotnet ef database update
dotnet run
