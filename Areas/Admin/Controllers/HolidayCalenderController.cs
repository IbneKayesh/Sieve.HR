using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HolidayCalenderController : Controller
    {
        private readonly HRDbContext _context;
        public HolidayCalenderController(HRDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<HR_HOLIDAY_CALENDER> objList = _context.HR_HOLIDAY_CALENDER;
            return View(objList);
        }

        public IActionResult Create(int? id)
        {
            HR_HOLIDAY_CALENDER objDb = new HR_HOLIDAY_CALENDER();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = _context.HR_HOLIDAY_CALENDER.Find(id);
                return View(objDb);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_HOLIDAY_CALENDER obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_HOLIDAY_CALENDER.Add(obj);
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
