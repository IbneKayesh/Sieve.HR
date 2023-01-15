using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.EmpDetail
{
    public class EmpDetailRep : GenericRepository<HR_EMP_DETAIL>, IEmpDetailRep
    {
        public EmpDetailRep(HRDbContext context) : base(context) { }
    }
}
