using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DesignationController : Controller
    {
        private readonly HRDbContext _context;
        public DesignationController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_DESIGNATIONS> objList = _context.HR_DESIGNATIONS;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            //return View();

            HR_DESIGNATIONS objDb = new HR_DESIGNATIONS();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_DESIGNATIONS.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_DESIGNATIONS obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_DESIGNATIONS.Add(obj);
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
            var Deleterecord = _context.HR_DESIGNATIONS.Find(id);

            if (id == null || id == 0 || Deleterecord == null)
            {
                return Json(new JSON_CONFIRM_MESSAGES("Failed"));
            }
            else
            {
                _context.HR_DESIGNATIONS.Remove(Deleterecord);
                _context.SaveChanges();
                return Json(new JSON_CONFIRM_MESSAGES(true, id.ToString())); ;
            }

        }
    }
}
