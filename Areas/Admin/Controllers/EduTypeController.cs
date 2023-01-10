using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EduTypeController : Controller
    {
        private readonly HRDbContext _context;
        public EduTypeController(HRDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_EDU_TYPE> objList = _context.HR_EDU_TYPE;
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            //return View();

            HR_EDU_TYPE objDb = new HR_EDU_TYPE();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_EDU_TYPE.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EDU_TYPE obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_EDU_TYPE.Add(obj);
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
