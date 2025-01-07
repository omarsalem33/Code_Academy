
# Code Academy - Participant Management System

This project is designed to manage participants in a code academy environment. It uses **Entity Framework Core** and **LINQ** to manage participant data, with support for different types of participants such as `Individual` and `Corporate`. 

The project demonstrates concepts like inheritance in EF Core, LINQ queries, and relationships between entities.

## Features

- **Participants**: A base `Participant` class with properties like `Id`, `FName`, and `LName`.
- **Individual Participants**: A derived class from `Participant` for managing individual participants, with additional properties like `University`, `YearOfGraduation`, and `IsIntern`.
- **Corporate Participants**: Another derived class (you can add this) to represent corporate participants.
- **LINQ Queries**: Examples of LINQ usage for querying participant data, including filtering, sorting, and projections.
- **Data Seeding**: Initial data is seeded into the database for testing purposes.

## Getting Started

### Prerequisites

Ensure that you have the following installed:
- .NET 6 or later.
- SQL Server (or a compatible database system).
- Visual Studio (or any IDE of your choice).

### Clone the Repository

To get started, clone this repository to your local machine:

```bash
git clone https://github.com/omarsalem33/Code_Academy.git
cd Code_Academy
```

### Setup the Database

1. Ensure your connection string is configured in `appsettings.json`.
2. Use **Entity Framework Core** to create and apply migrations.

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

This will create the necessary database schema in your SQL Server.

### Running the Application

To run the application locally, use the following command:

```bash
dotnet run
```

This will start the application on `http://localhost:5000`.

## Project Structure

- **Entities**:
  - `Participant`: The base class for all participants, containing common properties like `Id`, `FName`, and `LName`.
  - `Individual`: A derived class for individual participants with properties such as `University`, `YearOfGraduation`, and `IsIntern`.
  - `Corporate`: You can create this class for corporate participants with properties like `CompanyName` and `Position` (optional).
  
- **LINQ Queries**: Demonstrates LINQ queries to filter, group, and sort participant data.

- **Data Seeding**: Seed data is included in the `OnModelCreating` method for testing purposes.

## Usage

### Example LINQ Queries

Here are some examples of how to use LINQ to query participants:

#### 1. Fetch All Participants:

```csharp
var allParticipants = context.Participants.ToList();
```

#### 2. Filter by Type (e.g., `Individual` participants):

```csharp
var individuals = context.Set<Individual>().ToList();
```

#### 3. Project Selected Fields:

```csharp
var participantsData = context.Participants
    .Select(p => new 
    {
        p.FName,
        p.LName,
        p.YearOfGraduation,
        p.University,
        p.IsIntern
    })
    .ToList();
```

#### 4. Aggregate Data (Count and Average):

```csharp
var count = context.Participants.Count();
var avgGraduationYear = context.Set<Individual>().Average(i => i.YearOfGraduation);
```

### Data Seeding

You can customize and extend the seed data in the `OnModelCreating` method of your `DbContext`. The sample data will be inserted into the database when it is first created.

```csharp
modelBuilder.Entity<Individual>().HasData(
    new Individual { Id = 1, FName = "John", LName = "Doe", University = "XYZ University", YearOfGraduation = 2023, IsIntern = true }
);
```

## Running Unit Tests

To ensure the integrity of the repository methods and LINQ queries, run the unit tests:

```bash
dotnet test
```

The tests cover repository methods and LINQ queries to ensure correctness.

## Contributing

If you would like to contribute to this project, follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add your feature'`).
5. Push to your branch (`git push origin feature/your-feature`).
6. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
