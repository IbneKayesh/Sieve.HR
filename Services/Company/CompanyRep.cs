using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.Company
{
    public class CompanyRep : GenericRepository<HR_COMPANY>, ICompanyRep
    {
        public CompanyRep(HRDbContext context) : base(context) { }

        public Int64 AvailableEmployeeDesk(int entityId, int maxEmp)
        {
            return maxEmp - context.HR_DEPARTMENT.Where(c => c.COMP_ID == entityId).Sum(s => s.MAX_EMP_NO);
        }

        public double AvailableLeftSalary(int entityId, int maxSalary)
        {
            return maxSalary - context.HR_DEPARTMENT.Where(c => c.COMP_ID == entityId).Sum(s => s.MAX_SALARY);
        }
    }
}
