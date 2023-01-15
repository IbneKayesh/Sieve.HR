using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmpLeaveAppController : Controller
    {
        private readonly HRDbContext _context;
        public EmpLeaveAppController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_EMP_LEAVE_APPS> objList = _context.HR_EMP_LEAVE_APPS;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            HR_EMP_LEAVE_APPS objDb = new HR_EMP_LEAVE_APPS();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_EMP_LEAVE_APPS.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EMP_LEAVE_APPS obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_EMP_LEAVE_APPS.Add(obj);
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
