using TestFlow.Domain.Entities;
using TestFlow.Domain.Enums;
using TestFlow.Domain.Services;

namespace TestFlow.Tests;

public class PermissionServiceTests
{
    private readonly PermissionService _permissionService = new();

    [Fact]
    public void CanReview_WhenReviewerIsHigherLevel_ReturnsTrue()
    {
        var reviewer = new Employee
        {
            Level = EmployeeLevel.E5
        };

        var employeeBeingReviewed = new Employee
        {
            Level = EmployeeLevel.E3
        };

        var result = _permissionService.CanReview(
            reviewer,
            employeeBeingReviewed);

        Assert.True(result);
    }

    [Fact]
    public void CanReview_WhenReviewerIsSameLevel_ReturnsTrue()
    {
        var reviewer = new Employee
        {
            Level = EmployeeLevel.E5
        };

        var employeeBeingReviewed = new Employee
        {
            Level = EmployeeLevel.E5
        };

        var result = _permissionService.CanReview(
            reviewer,
            employeeBeingReviewed);

        Assert.True(result);
    }

    [Fact]
    public void CanReview_WhenReviewerIsLowerLevel_ReturnsFalse()
    {
        var reviewer = new Employee
        {
            Level = EmployeeLevel.E5
        };

        var employeeBeingReviewed = new Employee
        {
            Level = EmployeeLevel.E6
        };

        var result = _permissionService.CanReview(
            reviewer,
            employeeBeingReviewed);

        Assert.False(result);
    }
}