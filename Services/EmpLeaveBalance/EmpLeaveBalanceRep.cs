using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.AttendanceSheet;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.EmpLeaveBalance
{
    public class EmpLeaveBalanceRep : GenericRepository<HR_EMP_LEAVE_BALANCE>, IEmpLeaveBalanceRep
    {
        public EmpLeaveBalanceRep(HRDbContext context) : base(context) { }
    }
}
