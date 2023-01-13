﻿using Sieve.HR.Services.Company;
using Sieve.HR.Services.Department;
using Sieve.HR.Services.Section;

namespace Sieve.HR.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRep Company { get; }
        IDepartmentRep Department { get; }
        ISectionRep Section { get; }

        EQResult Commit();
    }
}
