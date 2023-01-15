using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;
using Sieve.HR.Services.EmpRoster;

namespace Sieve.HR.Services.EmpJob
{
    public class EmpJobRep : GenericRepository<HR_EMP_JOB>, IEmpJobRep
    {
        public EmpJobRep(HRDbContext context) : base(context) { }
    }
}
