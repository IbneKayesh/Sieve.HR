using Microsoft.AspNetCore.Mvc.Rendering;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.EmpDetail
{
    public class EmpDetailRep : GenericRepository<HR_EMP_DETAIL>, IEmpDetailRep
    {
        public EmpDetailRep(HRDbContext context) : base(context) { }
        public string GetNewEmpNo()
        {
            var NextEmp_No = "";
            string? EMP_NO = context.HR_EMP_DETAIL.OrderByDescending(p => p.ID).FirstOrDefault()?.EMP_NO;
            if (string.IsNullOrEmpty(EMP_NO))
            {
                NextEmp_No = "EMP-" + "0".PadLeft(5, '0');
            }
            else
            {
                string[] split = EMP_NO.Split('-');
                int nextID = int.Parse(split[1]) + 1;
                NextEmp_No = "EMP-" + nextID.ToString().PadLeft(5, '0');
            }
            return NextEmp_No;
        }

        public List<SelectListItem> GenderDropdown()
        {
            return new List<SelectListItem>() 
            {
                new SelectListItem { Text = "Male", Value = "Male" },
                new SelectListItem { Text = "Female", Value = "Female"},
                new SelectListItem { Text = "Third Gender", Value = "Third Gender"}
            };
        }

        public List<SelectListItem> MaritailStatusDropdown()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem { Text = "Married", Value = "Married" },
                new SelectListItem { Text = "Unmarried", Value = "Unmarried" },
                new SelectListItem { Text = "Divorce", Value = "Divorce" }
            };
        }
    }
}
