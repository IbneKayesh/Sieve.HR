using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentController : Controller
    {
        private readonly HRDbContext _context;
        public DepartmentController(HRDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<HR_DEPARTMENT> objList = _context.HR_DEPARTMENT;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            DropDownListFor_Create();
            HR_DEPARTMENT objDb = new HR_DEPARTMENT();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_DEPARTMENT.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_DEPARTMENT obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_DEPARTMENT.Add(obj);
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
            var Deleterecord = _context.HR_DEPARTMENT.Find(id);

            if (id == null || id == 0 || Deleterecord == null)
            {
                return Json(new JSON_CONFIRM_MESSAGES("Failed"));
            }
            else
            {
                _context.HR_DEPARTMENT.Remove(Deleterecord);
                _context.SaveChanges();
                return Json(new JSON_CONFIRM_MESSAGES(true, id.ToString())); ;
            }

        }

        private void DropDownListFor_Create()
        {
            ViewBag.COMP_ID = _context.HR_COMPANY.Select(s => new SelectListItem() { Text = s.COMP_NAME, Value = s.ID.ToString() }).ToList();
        }
    }
}
