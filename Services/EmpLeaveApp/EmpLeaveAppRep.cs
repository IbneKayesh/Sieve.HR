using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.AttendanceSheet;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.EmpLeaveApp
{
    public class EmpLeaveAppRep : GenericRepository<HR_EMP_LEAVE_APPS>, IEmpLeaveAppRep
    {
        public EmpLeaveAppRep(HRDbContext context) : base(context) { }
    }
}
