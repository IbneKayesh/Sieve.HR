using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SalaryTypeController : Controller
    {
        private readonly HRDbContext _context;
        public SalaryTypeController(HRDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<HR_SALARY_TYPE> objList = _context.HR_SALARY_TYPE;
            return View(objList);
        }

        public IActionResult Create(int? id)
        {
            HR_SALARY_TYPE objDb = new HR_SALARY_TYPE();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = _context.HR_SALARY_TYPE.Find(id);
                return View(objDb);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_SALARY_TYPE obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_SALARY_TYPE.Add(obj);
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
