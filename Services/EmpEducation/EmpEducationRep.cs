using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.AttendanceSheet;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.EmpEducation
{
    public class EmpEducationRep : GenericRepository<HR_EMP_EDU>, IEmpEducationRep
    {
        public EmpEducationRep(HRDbContext context) : base(context) { }
    }
}
