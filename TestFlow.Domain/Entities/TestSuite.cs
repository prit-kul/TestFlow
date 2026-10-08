namespace TestFlow.Domain.Entities;

public class TestSuite
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Guid ProjectId { get; set; }
}