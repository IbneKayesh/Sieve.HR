using Sieve.HR.Services.AttendanceSheet;
using Sieve.HR.Services.Company;
using Sieve.HR.Services.Db;
using Sieve.HR.Services.Department;
using Sieve.HR.Services.Designation;
using Sieve.HR.Services.DutyRoster;
using Sieve.HR.Services.EduType;
using Sieve.HR.Services.EmpDetail;
using Sieve.HR.Services.EmpEducation;
using Sieve.HR.Services.EmpJob;
using Sieve.HR.Services.EmpLeaveApp;
using Sieve.HR.Services.EmpLeaveBalance;
using Sieve.HR.Services.EmpPayslip;
using Sieve.HR.Services.EmpPayslipDetail;
using Sieve.HR.Services.EmpRef;
using Sieve.HR.Services.EmpRoster;
using Sieve.HR.Services.EmpSalary;
using Sieve.HR.Services.HolidayCalender;
using Sieve.HR.Services.LeaveType;
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
            AttendanceSheet = new AttendanceSheetRep(context);
            Company = new CompanyRep(context);
            Department = new DepartmentRep(context);
            Designation = new DesignationRep(context);
            DutyRoster = new DutyRosterRep(context);
            EduType = new EduTypeRep(context);
            EmpDetail = new EmpDetailRep(context);
            EmpEducation = new EmpEducationRep(context);
            EmpJob = new EmpJobRep(context);
            EmpLeaveApp = new EmpLeaveAppRep(context);
            EmpLeaveBalance = new EmpLeaveBalanceRep(context);
            EmpPayslip = new EmpPayslipRep(context);
            EmpPayslipDetail = new EmpPayslipDetailRep(context);
            EmpRef = new EmpRefRep(context);
            EmpRoster = new EmpRosterRep(context);
            EmpSalary = new EmpSalaryRep(context);
            HolidayCalender = new HolidayCalenderRep(context);
            LeaveType = new LeaveTypeRep(context);
            SalaryType = new SalaryTypeRep(context);
            Section = new SectionRep(context);
        }

        #region OldCode
        //public IAttendanceSheetRep AttendanceSheet { get; private set; }
        //public ICompanyRep Company { get; private set; }
        //public IDepartmentRep Department { get; private set; }
        //public IDesignationRep Designation { get; private set; }
        //public IDutyRosterRep DutyRoster { get; private set; }
        //public IEmpDetailRep EmpDetail { get; private set; }
        //public IEmpJobRep EmpJob { get; private set; }
        //public IEmpRosterRep EmpRoster { get; private set; }
        //public ISalaryTypeRep SalaryType { get; private set; }
        //public ISectionRep Section { get; private set; }
        #endregion

        public IAttendanceSheetRep AttendanceSheet { get; private set; }
        public ICompanyRep Company { get; private set; }
        public IDepartmentRep Department { get; private set; }
        public IDesignationRep Designation { get; private set; }
        public IDutyRosterRep DutyRoster { get; private set; }
        public IEduTypeRep EduType { get; private set; }
        public IEmpDetailRep EmpDetail { get; private set; }
        public IEmpEducationRep EmpEducation { get; private set; }
        public IEmpJobRep EmpJob { get; private set; }
        public IEmpLeaveAppRep EmpLeaveApp { get; private set; }
        public IEmpLeaveBalanceRep EmpLeaveBalance { get; private set; }
        public IEmpPayslipRep EmpPayslip { get; private set; }
        public IEmpPayslipDetailRep EmpPayslipDetail { get; private set; }
        public IEmpRefRep EmpRef { get; private set; }
        public IEmpRosterRep EmpRoster { get; private set; }
        public IEmpSalaryRep EmpSalary { get; private set; }
        public IHolidayCalenderRep HolidayCalender { get; private set; }
        public ILeaveTypeRep LeaveType { get; private set; }
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
