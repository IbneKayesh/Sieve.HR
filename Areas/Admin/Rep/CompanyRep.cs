using Sieve.HR.Areas.Admin.IRep;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Rep
{
    public class CompanyRep : GenericRepository<HR_COMPANY>, ICompanyRep
    {
        public CompanyRep(HRDbContext context) : base(context) { }
    }
}
