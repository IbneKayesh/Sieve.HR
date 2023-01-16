using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;
using Sieve.HR.Services.EmpRoster;

namespace Sieve.HR.Services.EmpSalary
{
    public class EmpSalaryRep : GenericRepository<HR_EMP_SALARY>, IEmpSalaryRep
    {
        public EmpSalaryRep(HRDbContext context) : base(context) { }
    }
}
