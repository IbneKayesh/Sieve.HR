using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;

namespace Sieve.HR.Services.Section
{
    public interface ISectionRep : IGenericRepository<HR_SECTIONS>
    {
        Int64 AvailableNumberOfEmp(int entityDeptId);
        double AvailableLeftSalary(int entityDeptId);
    }
}
