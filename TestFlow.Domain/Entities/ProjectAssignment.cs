namespace TestFlow.Domain.Entities;

public class ProjectAssignment
{
    public Guid Id { get; set; }

    public Guid EmployeeId { get; set; }

    public Guid ProjectId { get; set; }
}