using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;
using Sieve.HR.Services.EmpSalary;

namespace Sieve.HR.Services.HolidayCalender
{
    public class HolidayCalenderRep : GenericRepository<HR_HOLIDAY_CALENDER>, IHolidayCalenderRep
    {
        public HolidayCalenderRep(HRDbContext context) : base(context) { }
    }
}
