using Microsoft.AspNetCore.Mvc;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeePaySlipDetailController : Controller
    {
        private readonly HRDbContext _context;
        public EmployeePaySlipDetailController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_EMP_PAYSLIP_DETAIL> objList = _context.HR_EMP_PAYSLIP_DETAIL;
            return View(objList);
        }
    }
}
