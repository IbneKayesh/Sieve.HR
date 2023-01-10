using Sieve.HR.Areas.Admin.Models;

namespace Sieve.HR.Services.Db
{
    public class UnitOfWork : IDisposable
    {
        private HRDbContext context = new HRDbContext();
        private HRRepository<HR_COMPANY> HR_COMPANY_Repository;
        private HRRepository<HR_DEPARTMENT> HR_DEPARTMENT_Repository;

        public HRRepository<HR_COMPANY> HR_COMPANYRepository
        {
            get
            {
                if (this.HR_COMPANY_Repository == null)
                {
                    this.HR_COMPANY_Repository = new HRRepository<HR_COMPANY>(context);
                }
                return HR_COMPANY_Repository;
            }
        }

        public HRRepository<HR_DEPARTMENT> HR_DEPARTMENTRepository
        {
            get
            {
                if (this.HR_DEPARTMENT_Repository == null)
                {
                    this.HR_DEPARTMENT_Repository = new HRRepository<HR_DEPARTMENT>(context);
                }
                return HR_DEPARTMENT_Repository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
