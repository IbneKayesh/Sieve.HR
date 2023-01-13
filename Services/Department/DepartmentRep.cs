using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.Department
{
    public class DepartmentRep : GenericRepository<HR_DEPARTMENT>, IDepartmentRep
    {
        public DepartmentRep(HRDbContext context) : base(context) { }
        public Int64 AvailableEmployeeDesk(int entityId, int parentEntityId, int maxEmp)
        {
            return maxEmp - context.HR_SECTIONS.Where(c => c.DEPT_ID == entityId).Sum(s => s.MAX_EMP_NO);
        }

        public double AvailableLeftSalary(int entityId, int maxSalary)
        {
            return maxSalary - context.HR_SECTIONS.Where(c => c.DEPT_ID == entityId).Sum(s => s.MAX_SALARY);
        }
    }
}
