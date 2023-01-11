using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.IRep;

namespace Sieve.HR.Services.Db
{
    public interface IUnitOfWork: IDisposable
    {
        ICompanyRep Company { get; }


        int Commit();
    }
}
