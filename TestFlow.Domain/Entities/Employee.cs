using TestFlow.Domain.Enums;

namespace TestFlow.Domain.Entities;

public class Employee
{
 public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public EmployeeLevel Level { get; set; }

    public EmployeeRole Role { get; set; }
}