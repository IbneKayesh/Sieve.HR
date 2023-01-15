using Microsoft.AspNetCore.Mvc.Rendering;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.SalaryType
{
    public class SalaryTypeRep : GenericRepository<HR_SALARY_TYPE>, ISalaryTypeRep
    {
        public SalaryTypeRep(HRDbContext context) : base(context) { }

        public List<SelectListItem> SelectListsTypeEffect()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();
            listItems.Add(new SelectListItem { Text = "Payable", Value = "0", Selected = true });
            listItems.Add(new SelectListItem { Text = "Deduction", Value = "1", Selected = false });
            return listItems;
        }
    }
}
