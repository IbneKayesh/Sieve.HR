using Sieve.HR.Services.Company;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private HRDbContext context;
        public UnitOfWork(HRDbContext context)
        {
            this.context = context;
            Company = new CompanyRep(this.context);
        }
        public ICompanyRep Company { get; private set; }











          
        EQResult IUnitOfWork.Commit()
        {
            EQResult eQ = new EQResult();
            try
            {
                eQ.ROWS = context.SaveChanges();
            }
            catch (Exception ex)
            {
                eQ.SUCCESS = false;
                eQ.MESSAGES = ex.Message;
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
