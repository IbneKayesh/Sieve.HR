using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmpRosterController : Controller
    {
        private readonly HRDbContext _context;
        public EmpRosterController(HRDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<HR_EMP_ROSTER> objList = _context.HR_EMP_ROSTER;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {

            HR_EMP_ROSTER objDb = new HR_EMP_ROSTER();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_EMP_ROSTER.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EMP_ROSTER obj)
        {

            if (ModelState.IsValid)
            {
                if (obj.EMP_ID <= 0)
                {
                    _context.HR_EMP_ROSTER.Add(obj);
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
            var Deleterecord = _context.HR_EMP_ROSTER.Find(id);

            if (id == null || id == 0 || Deleterecord == null)
            {
                return Json(new JSON_CONFIRM_MESSAGES("Failed"));
            }
            else
            {
                _context.HR_EMP_ROSTER.Remove(Deleterecord);
                _context.SaveChanges();
                return Json(new JSON_CONFIRM_MESSAGES(true, id.ToString())); ;
            }

        }

    }
}
