using Sieve.HR.Services.Company;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private HRDbContext context;
        public UnitOfWork(HRDbContext _context)
        {
            this.context = _context;
            Company = new CompanyRep(context);
        }
        public ICompanyRep Company { get; private set; }











          
        EQResult IUnitOfWork.Commit()
        {
            EQResult eQ = new EQResult();
            try
            {
                context.Database.BeginTransaction();
                eQ.ROWS = context.SaveChanges();
                context.Database.CommitTransaction();
            }
            catch (Exception ex)
            {
                context.Database.RollbackTransaction();
                eQ.SUCCESS = false;
                eQ.MESSAGES = ex.Message.Contains("See the inner exception for details") ? ex.InnerException?.Message : ex.Message;
                eQ.ROWS = 0;
            }
            return eQ;
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
