
using TestFlow.Domain.Entities;
using TestFlow.Domain.Enums;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// In-memory dummy data shared by both endpoints.
var employees = new List<Employee>
{
    new()
    {
        Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
        Name = "Amit Sharma",
        Email = "amit@example.com",
        Level = EmployeeLevel.E3,
        Role = EmployeeRole.QAEngineer
    },
    new()
    {
        Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
        Name = "Priya Patil",
        Email = "priya@example.com",
        Level = EmployeeLevel.E5,
        Role = EmployeeRole.AutomationEngineer
    }
};

// GET /api/employees
// Returns all employees.
app.MapGet("/api/employees", () =>
{
    return Results.Ok(employees);
});

// GET /api/employees/{id}
// Returns one employee by ID.
app.MapGet("/api/employees/{id}", (Guid id) =>
{
    var employee = employees.FirstOrDefault(e => e.Id == id);

    if (employee is null)
    {
        return Results.NotFound();
    }

    return Results.Ok(employee);
})
.WithName("GetEmployeeById");

///Post

app.MapPost("/api/employees", (CreateEmployeeRequest request) =>
{
    // Validate required fields.
    if (string.IsNullOrWhiteSpace(request.Name) ||
        string.IsNullOrWhiteSpace(request.Email))
    {
        return Results.BadRequest(new
        {
            message = "Name and Email are required."
        });
    }

    // Create a new employee.
    var employee = new Employee
    {
        Id = Guid.NewGuid(),
        Name = request.Name.Trim(),
        Email = request.Email.Trim(),
        Level = request.Level,
        Role = request.Role
    };

    // Add the employee to our in-memory list.
    employees.Add(employee);

    // Return 201 Created and the new employee.
    return Results.Created(
        $"/api/employees/{employee.Id}",
        employee);
})
.WithName("CreateEmployee");

//// Put
app.MapPut("/api/employees/{id}", (Guid id, CreateEmployeeRequest request) =>
{
    var employee = employees.FirstOrDefault(e => e.Id == id);

    if (employee is null)
    {
        return Results.NotFound();
    }

    if (string.IsNullOrWhiteSpace(request.Name) ||
        string.IsNullOrWhiteSpace(request.Email))
    {
        return Results.BadRequest(new
        {
            message = "Name and Email are required."
        });
    }

    employee.Name = request.Name.Trim();
    employee.Email = request.Email.Trim();
    employee.Level = request.Level;
    employee.Role = request.Role;

    return Results.Ok(employee);
})
.WithName("UpdateEmployee");

///Delete
app.MapDelete("/api/employees/{id}", (Guid id) =>
{
    var employee = employees.FirstOrDefault(e => e.Id == id);

    if (employee is null)
    {
        return Results.NotFound();
    }

    employees.Remove(employee);

    return Results.NoContent();
})
.WithName("DeleteEmployee");


app.Run();

public partial class Program
{
}

public record CreateEmployeeRequest(
    string Name,
    string Email,
    EmployeeLevel Level,
    EmployeeRole Role);

