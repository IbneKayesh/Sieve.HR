﻿using Sieve.HR.Services.Company;
using Sieve.HR.Services.Department;
using Sieve.HR.Services.Designation;
using Sieve.HR.Services.DutyRoster;
using Sieve.HR.Services.EmpDetail;
using Sieve.HR.Services.SalaryType;
using Sieve.HR.Services.Section;

namespace Sieve.HR.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRep Company { get; }
        IDepartmentRep Department { get; }
        IDesignationRep Designation { get; }
        IDutyRosterRep DutyRoster { get; }
        ISalaryTypeRep SalaryType { get; }
        ISectionRep Section { get; }
        IEmpDetailRep EmpDetail { get; }

        EQResult Commit();
    }
}
