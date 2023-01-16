using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;
using Sieve.HR.Services.EmpPayslip;

namespace Sieve.HR.Services.EmpPayslipDetail
{
    public class EmpPayslipDetailRep : GenericRepository<HR_EMP_PAYSLIP_DETAIL>, IEmpPayslipDetailRep
    {
        public EmpPayslipDetailRep(HRDbContext context) : base(context) { }
    }
}
