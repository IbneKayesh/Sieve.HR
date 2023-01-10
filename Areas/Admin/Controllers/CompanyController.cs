using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;
using Sieve.HR.Utilities;

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
        public IActionResult Create(int? id)
        {
            HR_COMPANY objDb = new HR_COMPANY();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            objDb = _context.HR_COMPANY.Find(id);
            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_COMPANY obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_COMPANY.Add(obj);
                }
                else
                {
                    _context.Entry(obj).State = EntityState.Modified;
                }
                _context.SaveChanges();
                TempData["msg"] = SweetMessages.SaveSuccessOK();
                return RedirectToAction(nameof(Create));
            }
            return View(obj);
        }


        public IActionResult Delete(int? id)
        {
            var Deleterecord = _context.HR_COMPANY.Find(id);

            if (id == null || id == 0 ||  Deleterecord == null)
            {
                return Json(new JSON_CONFIRM_MESSAGES("Failed"));
            }
            else
            {
                _context.HR_COMPANY.Remove(Deleterecord);
                _context.SaveChanges();
                return Json(new JSON_CONFIRM_MESSAGES(true,id.ToString())); ;
            }

        }
    }
}
