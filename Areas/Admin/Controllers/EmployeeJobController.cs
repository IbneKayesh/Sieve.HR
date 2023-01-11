using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeJobController : Controller
    {
        private readonly HRDbContext _context;
        public EmployeeJobController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_EMP_JOB> objList = _context.HR_EMP_JOB;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            //return View();
            DropDownListFor_Create();
            HR_EMP_JOB objDb = new HR_EMP_JOB();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_EMP_JOB.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EMP_JOB obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_EMP_JOB.Add(obj);
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
            ViewBag.DESIG_ID = _context.HR_DESIGNATIONS.Select(s => new SelectListItem() { Text = s.SHORT_FORM.ToString(), Value = s.ID.ToString() }).ToList();

            ViewBag.SECTION_ID = _context.HR_SECTIONS.Select(s => new SelectListItem() { Text = s.SECT_NAME.ToString(), Value = s.ID.ToString() }).ToList();
        }
    }
}
