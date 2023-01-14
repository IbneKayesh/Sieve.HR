using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LeaveTypeController : Controller
    {
        private readonly HRDbContext _context;
        public LeaveTypeController(HRDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<HR_LEAVE_TYPE> objList = _context.HR_LEAVE_TYPE;
            return View(objList);
        }

        public IActionResult Create(int? id)
        {
            HR_LEAVE_TYPE objDb = new HR_LEAVE_TYPE();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = _context.HR_LEAVE_TYPE.Find(id);
                return View(objDb);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_LEAVE_TYPE obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_LEAVE_TYPE.Add(obj);
                }
                else
                {
                    _context.Entry(obj).State = EntityState.Modified;
                }
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added/Updated Successfully !";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
