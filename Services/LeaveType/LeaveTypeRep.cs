using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;
using Sieve.HR.Services.HolidayCalender;

namespace Sieve.HR.Services.LeaveType
{
    public class LeaveTypeRep : GenericRepository<HR_LEAVE_TYPE>, ILeaveTypeRep
    {
        public LeaveTypeRep(HRDbContext context) : base(context) { }
    }
}
