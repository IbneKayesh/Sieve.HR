using Microsoft.AspNetCore.Mvc;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompanyController : Controller
    {
        private readonly HRDbContext _context;
        public CompanyController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_COMPANY> objList = _context.HR_COMPANY;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_COMPANY obj)
        {
            if (ModelState.IsValid)
            {
                _context.HR_COMPANY.Add(obj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added Successfully !";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var objDb = _context.HR_COMPANY.Find(id);

            if (objDb == null)
            {
                return NotFound();
            }
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HR_COMPANY obj)
        {
            if (ModelState.IsValid)
            {
                _context.HR_COMPANY.Update(obj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Data Updated Successfully !";
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var objDb = _context.HR_COMPANY.Find(id);

            if (objDb == null)
            {
                return NotFound();
            }
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteRecord(int? id)
        {
            var deleterecord = _context.HR_COMPANY.Find(id);
            if (deleterecord == null)
            {
                return NotFound();
            }
            _context.HR_COMPANY.Remove(deleterecord);
            _context.SaveChanges();
            TempData["ResultOk"] = "Data Deleted Successfully !";
            return RedirectToAction("Index");
        }
    }
}
