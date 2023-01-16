using Sieve.HR.Services.AttendanceSheet;
using Sieve.HR.Services.Company;
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
    public interface IUnitOfWork : IDisposable
    {

        IAttendanceSheetRep AttendanceSheet { get; }
        ICompanyRep Company { get; }
        IDepartmentRep Department { get; }
        IDesignationRep Designation { get; }
        IDutyRosterRep DutyRoster { get; }
        IEduTypeRep EduType { get; }
        IEmpDetailRep EmpDetail { get; }
        IEmpEducationRep EmpEducation { get; }
        IEmpJobRep EmpJob { get; }
        IEmpLeaveAppRep EmpLeaveApp { get; }
        IEmpLeaveBalanceRep EmpLeaveBalance { get; }
        IEmpPayslipRep EmpPayslip { get; }
        IEmpPayslipDetailRep EmpPayslipDetail { get; }
        IEmpRefRep EmpRef { get; }
        IEmpRosterRep EmpRoster { get; }
        IEmpSalaryRep EmpSalary { get; }
        IHolidayCalenderRep HolidayCalender { get; }
        ILeaveTypeRep LeaveType { get; }
        ISalaryTypeRep SalaryType { get; }
        ISectionRep Section { get; }

        EQResult Commit();
    }
}
