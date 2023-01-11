using Microsoft.AspNetCore.Mvc;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeePaySlipController : Controller
    {
        private readonly HRDbContext _context;
        public EmployeePaySlipController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_EMP_PAYSLIP> objList = _context.HR_EMP_PAYSLIP;
            return View(objList);
        }
    }
}
