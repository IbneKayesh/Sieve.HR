using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Company;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.AttendanceSheet
{
    public class AttendanceSheetRep : GenericRepository<HR_ATTENDANCE_SHEET>, IAttendanceSheetRep
    {
        public AttendanceSheetRep(HRDbContext context) : base(context) { }
    }
}
