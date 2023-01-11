using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeLeaveBalanceController : Controller
    {
        private readonly HRDbContext _context;
        public EmployeeLeaveBalanceController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_EMP_LEAVE_BALANCE> objList = _context.HR_EMP_LEAVE_BALANCE;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            HR_EMP_LEAVE_BALANCE objDb = new HR_EMP_LEAVE_BALANCE();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_EMP_LEAVE_BALANCE.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EMP_LEAVE_BALANCE obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_EMP_LEAVE_BALANCE.Add(obj);
                }
                else
                {
                    _context.Entry(obj).State = EntityState.Modified;
                }
                _context.SaveChanges();
                TempData["msg"] = SweetMessages.SaveSuccessOK();
                return RedirectToAction(nameof(Create));
            }
            return View(obj);
        }
    }
}
