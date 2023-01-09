using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SectionController : Controller
    {
        private readonly HRDbContext _context;
        public SectionController(HRDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<HR_SECTIONS> objList = _context.HR_SECTIONS;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            DropDownListFor_Create();
            HR_SECTIONS objDb = new HR_SECTIONS();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_SECTIONS.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_SECTIONS obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_SECTIONS.Add(obj);
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

        private void DropDownListFor_Create()
        {
            ViewBag.DEPT_ID = _context.HR_DEPARTMENT.Select(s => new SelectListItem() { Text = s.DEPT_NAME + "-" + s.HR_COMPANY.COMP_NAME, Value = s.ID.ToString() }).ToList();
        }
    }
}
