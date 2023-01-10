using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeEducationController : Controller
    {
        private readonly HRDbContext _context;
        public EmployeeEducationController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_EMP_EDU> objList = _context.HR_EMP_EDU;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            //return View();
            DropDownListFor_Create();
            HR_EMP_EDU objDb = new HR_EMP_EDU();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_EMP_EDU.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EMP_EDU obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_EMP_EDU.Add(obj);
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
            ViewBag.EDU_TYPE_ID = _context.HR_EDU_TYPE.Select(s => new SelectListItem() { Text = s.TYPE_NAME, Value = s.ID.ToString() }).ToList();
        }
    }
}
