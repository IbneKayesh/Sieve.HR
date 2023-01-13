using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;

namespace Sieve.HR.Services.Department
{
    public interface IDepartmentRep : IGenericRepository<HR_DEPARTMENT>
    {
        Int64 AvailableEmployeeDesk(int entityId, int parentEntityId, int maxEmp);
        double AvailableLeftSalary(int entityId, int maxSalary);
    }
}
