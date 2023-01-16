using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;
using Sieve.HR.Services.EmpLeaveBalance;

namespace Sieve.HR.Services.EmpPayslip
{
    public class EmpPayslipRep : GenericRepository<HR_EMP_PAYSLIP>, IEmpPayslipRep
    {
        public EmpPayslipRep(HRDbContext context) : base(context) { }
    }
}
