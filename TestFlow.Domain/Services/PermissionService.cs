using TestFlow.Domain.Entities;

namespace TestFlow.Domain.Services;

public class PermissionService
{
    public bool CanReview(Employee reviewer, Employee employeeBeingReviewed)
    {
        ArgumentNullException.ThrowIfNull(reviewer);
        ArgumentNullException.ThrowIfNull(employeeBeingReviewed);
        
        return reviewer.Level >= employeeBeingReviewed.Level;
    }
}