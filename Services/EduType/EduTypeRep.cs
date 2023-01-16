using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.AttendanceSheet;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.EduType
{
    public class EduTypeRep : GenericRepository<HR_EDU_TYPE>, IEduTypeRep
    {
        public EduTypeRep(HRDbContext context) : base(context) { }
    }
}
