using Microsoft.AspNetCore.Mvc;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public CompanyController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_COMPANY> objList = unitOfWork.Company.SelectAll();
            return View(objList);
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
                objDb = unitOfWork.Company.SelectById(id.Value);
                return View(objDb);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_COMPANY obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    // unitOfWork.Company.Insert(obj);
                    unitOfWork.Company.Insert2(obj);
                }
                else
                {
                    unitOfWork.Company.Update(obj);
                }
                EQResult eQ = unitOfWork.Commit();
                if (eQ.SUCCESS && eQ.ROWS > 0)
                {
                    TempData["msg"] = SweetMessages.SaveSuccessOK();
                }
                else
                {
                    TempData["msg"] = SweetMessages.ShowError(eQ.MESSAGES);
                }
                return RedirectToAction(nameof(Create));
            }
            TempData["msg"] = SweetMessages.ShowError(string.Join(", ", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage)));
            return View(obj);
        }


        public IActionResult Delete(int? id)
        {
            var obj = unitOfWork.Company.SelectById(id.Value);

            if (id == null || id == 0 || obj == null)
            {
                return Json(new JSON_CONFIRM_MESSAGES("Failed"));
            }
            else
            {
                unitOfWork.Company.Delete(obj);
                EQResult eQ = unitOfWork.Commit();
                return Json(new JSON_CONFIRM_MESSAGES(true, id.ToString()!)); ;
            }

        }
    }
}
