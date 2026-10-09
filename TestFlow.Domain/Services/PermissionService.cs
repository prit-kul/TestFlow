using TestFlow.Domain.Entities;

namespace TestFlow.Domain.Services;

public class PermissionService
{
    public bool CanReview(Employee reviewer, Employee employeeBeingReviewed)
    {
        return reviewer.Level >= employeeBeingReviewed.Level;
    }
}