using Sieve.HR.Services.Company;
using Sieve.HR.Services.Db;
using Sieve.HR.Services.Department;
using Sieve.HR.Services.Designation;
using Sieve.HR.Services.DutyRoster;
using Sieve.HR.Services.SalaryType;
using Sieve.HR.Services.Section;

namespace Sieve.HR.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private HRDbContext context;
        public UnitOfWork(HRDbContext _context)
        {
            this.context = _context;
            Company = new CompanyRep(context);
            Department = new DepartmentRep(context);
            Designation = new DesignationRep(context);
            DutyRoster = new DutyRosterRep(context);
            SalaryType = new SalaryTypeRep(context);
            Section = new SectionRep(context);
        }
        public ICompanyRep Company { get; private set; }
        public IDepartmentRep Department { get; private set; }
        public IDesignationRep Designation { get; private set; }
        public IDutyRosterRep DutyRoster { get; private set; }
        public ISalaryTypeRep SalaryType { get; private set; }
        public ISectionRep Section { get; private set; }



        //Transaction Commit

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
