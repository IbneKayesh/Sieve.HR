using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentController : Controller
    {

        private readonly IUnitOfWork unitOfWork;
        public DepartmentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            //Include IEnumerable<HR_DEPARTMENT> objList = unitOfWork.Department.SelectAll(includes: x=>x.HR_COMPANY);
            //Filter IEnumerable<HR_DEPARTMENT> objList = unitOfWork.Department.SelectAll(filter: x => x.DEPT_NAME == "Admin");
            //Order By IEnumerable<HR_DEPARTMENT> objList = unitOfWork.Department.SelectAll(orderBy: x => x.OrderBy(x => x.COMP_ID));


            IEnumerable<HR_DEPARTMENT> objList = unitOfWork.Department.SelectAll(orderBy: o => o.OrderBy(x => x.ID), includes: x => x.HR_COMPANY);
            foreach (HR_DEPARTMENT item in objList)
            {
                IEnumerable<HR_SECTIONS> subList = unitOfWork.Section.SelectAll(x => x.DEPT_ID == item.ID);
                item.MAX_EMP_NO_1 = subList.Sum(s => s.MAX_EMP_NO);
                item.MAX_SALARY_1 = subList.Sum(s => s.MAX_SALARY);
            }
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            DropDownListFor_Create();
            HR_DEPARTMENT objDb = new HR_DEPARTMENT();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = unitOfWork.Department.SelectById(id.Value);
                return View(objDb);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_DEPARTMENT obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    unitOfWork.Department.Insert(obj);
                }
                else
                {
                    Int64 maxEmp = unitOfWork.Department.AvailableEmployeeDesk(obj.ID, obj.COMP_ID, obj.MAX_EMP_NO);
                    if (maxEmp < 0)
                    {
                        TempData["msg"] = SweetMessages.ShowInfo($"Maximum number ({maxEmp}) of employee is less then you entered");
                        return View(obj);
                    }
                    double maxSalary = unitOfWork.Department.AvailableLeftSalary(obj.ID, obj.MAX_SALARY);
                    if (maxSalary < 0)
                    {
                        TempData["msg"] = SweetMessages.ShowInfo($"Total Salary ({maxSalary}) of selected Department is less then you entered");
                        return View(obj);
                    }
                    unitOfWork.Department.Update(obj);
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
            var obj = unitOfWork.Department.SelectById(id.Value);

            if (id == null || id == 0 || obj == null)
            {
                return Json(new JSON_CONFIRM_MESSAGES("Failed"));
            }
            else
            {
                unitOfWork.Department.Delete(obj);
                EQResult eQ = unitOfWork.Commit();
                return Json(new JSON_CONFIRM_MESSAGES(true, id.ToString()!));
            }
        }

        private void DropDownListFor_Create()
        {
            ViewBag.COMP_ID = unitOfWork.Company.SelectAll().Select(s => new SelectListItem() { Text = s.COMP_NAME, Value = s.ID.ToString() }).ToList();
        }
    }
}
