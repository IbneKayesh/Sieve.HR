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
            IEnumerable<HR_COMPANY> objList = unitOfWork.Company.SelectAll(orderBy: x => x.OrderBy(o => o.ID));
            foreach (HR_COMPANY item in objList)
            {
                IEnumerable<HR_DEPARTMENT> subList = unitOfWork.Department.SelectAll(x => x.COMP_ID == item.ID);
                item.MAX_EMP_NO_1 = subList.Sum(s => s.MAX_EMP_NO);
                item.MAX_SALARY_1 = subList.Sum(s => s.MAX_SALARY);
            }
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
                    unitOfWork.Company.Insert(obj);
                }
                else
                {
                    Int64 maxEmp = unitOfWork.Company.AvailableEmployeeDesk(obj.ID, obj.MAX_EMP_NO);
                    if (maxEmp < 0)
                    {
                        TempData["msg"] = SweetMessages.ShowInfo($"Maximum number ({maxEmp}) of employee is less then you entered");
                        return View(obj);
                    }
                    double maxSalary = unitOfWork.Company.AvailableLeftSalary(obj.ID, obj.MAX_SALARY);
                    if (maxSalary < 0)
                    {
                        TempData["msg"] = SweetMessages.ShowInfo($"Total Salary ({maxSalary}) of selected Department is less then you entered");
                        return View(obj);
                    }
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
                return Json(new JSON_CONFIRM_MESSAGES(true, id.ToString()!));
            }

        }
    }
}
