using Sieve.HR.Areas.Admin.IRep;
using Sieve.HR.Areas.Admin.Rep;
using Sieve.HR.Migrations;

namespace Sieve.HR.Services.Db
{
    public class UnitOfWork : IUnitOfWork
    {
        private HRDbContext context;
        public UnitOfWork(HRDbContext context)
        {
            this.context = context;
            Company = new CompanyRep(this.context);
        }
        public ICompanyRep Company   { get;  private set;    }
        public void Dispose()
        {
            context.Dispose();
        }
        public int Commit()
        {
            try
            {
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"{ex.Message} is not a valid integer.");
            }
           
        }
    }
}
