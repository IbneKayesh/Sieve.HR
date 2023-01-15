using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;

namespace Sieve.HR.Services.Company
{
    public interface ICompanyRep : IGenericRepository<HR_COMPANY>
    { 
        Int64 AvailableEmpDesk(int entityId, int maxEmp);
        double AvailableLeftSalary(int entityId, int maxSalary);
    }
}
