﻿using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.Section
{
    public class SectionRep : GenericRepository<HR_SECTIONS>, ISectionRep
    {
        public SectionRep(HRDbContext context) : base(context) { }

        public long AvailableNumberOfEmployee(int entityDeptId)
        {
            var availableMaxEmployeeForTheSelectedDepartment = context.HR_DEPARTMENT.Where(c => c.ID == entityDeptId).Select(x=>x.MAX_EMP_NO).Single(); 
            var SumOfEmployeeAlreadyAssignedIntheDifferentSectionsUnderThisDepartment = context.HR_SECTIONS.Where(c => c.DEPT_ID == entityDeptId).Sum(s => s.MAX_EMP_NO);
            var EmployeeCanBeAssigned = availableMaxEmployeeForTheSelectedDepartment - SumOfEmployeeAlreadyAssignedIntheDifferentSectionsUnderThisDepartment;

            return EmployeeCanBeAssigned;
        }

        public double AvailableLeftSalary(int entityDeptId)
        {
            var availableMaxSalaryForTheSelectedDepartment = context.HR_DEPARTMENT.Where(c => c.ID == entityDeptId).Select(x => x.MAX_SALARY).Single();
            var SumOfSalaryAlreadyAssignedIntheDifferentSectionsUnderThisDepartment = context.HR_SECTIONS.Where(c => c.DEPT_ID == entityDeptId).Sum(s => s.MAX_SALARY);
            var SalaryCanBeAssigned = availableMaxSalaryForTheSelectedDepartment - SumOfSalaryAlreadyAssignedIntheDifferentSectionsUnderThisDepartment;

            return SalaryCanBeAssigned;
        }
    }
}
