using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SalaryTypeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public SalaryTypeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<HR_SALARY_TYPE> objList = unitOfWork.SalaryType.SelectAll(orderBy: x => x.OrderBy(x => x.ID));
            return View(objList);
        }

        public IActionResult Create(int? id)
        {
            DropDownListFor_Create();
            HR_SALARY_TYPE objDb = new HR_SALARY_TYPE();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = unitOfWork.SalaryType.SelectById(id.Value);
                return View(objDb);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_SALARY_TYPE obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    unitOfWork.SalaryType.Insert(obj);
                }
                else
                {
                    unitOfWork.SalaryType.Update(obj);
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
        private void DropDownListFor_Create()
        {
            ViewBag.TYPE_EFFECT = unitOfWork.SalaryType.SelectListTypeEffect();
        }
    }
}
