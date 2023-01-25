using Microsoft.AspNetCore.Mvc.Rendering;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;

namespace Sieve.HR.Services.EmpDetail
{
    public interface IEmpDetailRep : IGenericRepository<HR_EMP_DETAIL>
    {
        string GetNewEmpNo();
        List<SelectListItem> GenderDropdown();
        List<SelectListItem> MaritailStatusDropdown();
    }
}
