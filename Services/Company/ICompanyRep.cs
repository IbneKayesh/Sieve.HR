using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;

namespace Sieve.HR.Services.Company
{
    public interface ICompanyRep : IGenericRepository<HR_COMPANY>
    {
        void Insert2(HR_COMPANY entity);
    }
}
