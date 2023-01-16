using Microsoft.AspNetCore.Mvc.Rendering;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;

namespace Sieve.HR.Services.SalaryType
{
    public interface ISalaryTypeRep : IGenericRepository<HR_SALARY_TYPE>
    {
        List<SelectListItem> SelectListTypeEffect();
    }
}
