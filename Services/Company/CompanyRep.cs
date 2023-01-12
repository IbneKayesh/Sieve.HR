using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.Company
{
    public class CompanyRep : GenericRepository<HR_COMPANY>, ICompanyRep
    {
        public CompanyRep(HRDbContext context) : base(context) { }
    }
}
