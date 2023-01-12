using Microsoft.EntityFrameworkCore;
using Sieve.HR.Services.Company;

namespace Sieve.HR.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRep Company { get; }

        EQResult Commit();
    }
}
