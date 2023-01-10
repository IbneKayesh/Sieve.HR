using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DutyRosterController : Controller
    {
        private readonly HRDbContext _context;
        public DutyRosterController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_DUTY_ROSTER> objList = _context.HR_DUTY_ROSTER;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            //return View();

            HR_DUTY_ROSTER objDb = new HR_DUTY_ROSTER();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_DUTY_ROSTER.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_DUTY_ROSTER obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_DUTY_ROSTER.Add(obj);
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


        public IActionResult Delete(int? id)
        {
            var Deleterecord = _context.HR_DUTY_ROSTER.Find(id);

            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                _context.HR_DUTY_ROSTER.Remove(Deleterecord);
                _context.SaveChanges();
                TempData["ResultOk"] = "Data Deleted Successfully !";
                return RedirectToAction("Index");
            }

        }
    }
}
