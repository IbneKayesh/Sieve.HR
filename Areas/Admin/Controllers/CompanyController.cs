using Microsoft.AspNetCore.Mvc;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        // private readonly HRDbContext _context;
        public CompanyController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        //public CompanyController(HRDbContext context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            IEnumerable<HR_COMPANY> objList = unitOfWork.Company.GetAll();
            return View(objList);
            //IEnumerable<HR_COMPANY> objList = _context.HR_COMPANY;
            //return View(objList);
        }
        public IActionResult Create(int? id)
        {
            HR_COMPANY objDb = new HR_COMPANY();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = unitOfWork.Company.GetById(id.Value);
                return View(objDb);
            }
            //objDb = _context.HR_COMPANY.Find(id)!;         
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_COMPANY obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    // _context.HR_COMPANY.Add(obj);
                    unitOfWork.Company.Add(obj);
                }
                else
                {
                    //_context.Entry(obj).State = EntityState.Modified;
                    unitOfWork.Company.Update(obj);
                }
                //_context.SaveChanges();
                unitOfWork.Commit();
                TempData["msg"] = SweetMessages.SaveSuccessOK();
                return RedirectToAction(nameof(Create));
            }
            return View(obj);
        }


        public IActionResult Delete(int? id)
        {
            // var obj = _context.HR_COMPANY.Find(id);
            var obj = unitOfWork.Company.GetById(id.Value);

            if (id == null || id == 0 || obj == null)
            {
                return Json(new JSON_CONFIRM_MESSAGES("Failed"));
            }
            else
            {
                //_context.HR_COMPANY.Remove(obj);
                //_context.SaveChanges();
                unitOfWork.Company.Remove(obj);
                unitOfWork.Commit();
                return Json(new JSON_CONFIRM_MESSAGES(true, id.ToString()!)); ;
            }

        }
    }
}
