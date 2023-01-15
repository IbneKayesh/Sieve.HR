using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.EmpRoster
{
    public class EmpRosterRep : GenericRepository<HR_EMP_ROSTER>, IEmpRosterRep
    {
        public EmpRosterRep(HRDbContext context) : base(context) { }
    }
}
