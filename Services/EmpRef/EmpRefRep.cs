using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;
using Sieve.HR.Services.EmpPayslipDetail;

namespace Sieve.HR.Services.EmpRef
{
    public class EmpRefRep : GenericRepository<HR_EMP_REF>, IEmpRefRep
    {
        public EmpRefRep(HRDbContext context) : base(context) { }
    }
}
