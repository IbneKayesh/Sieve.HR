using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeSalaryController : Controller
    {
        private readonly HRDbContext _context;
        public EmployeeSalaryController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_EMP_SALARY> objList = _context.HR_EMP_SALARY;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            //return View();
            HR_EMP_SALARY objDb = new HR_EMP_SALARY();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = _context.HR_EMP_SALARY.Find(id);
                return View(objDb);
            }            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EMP_SALARY obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_EMP_SALARY.Add(obj);
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
