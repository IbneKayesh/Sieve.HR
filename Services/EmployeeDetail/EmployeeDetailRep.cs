using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.EmployeeDetail
{
    public class EmployeeDetailRep : GenericRepository<HR_EMP_DETAIL>, IEmployeeDetailRep
    {
        public EmployeeDetailRep(HRDbContext context) : base(context) { }
    }
}
