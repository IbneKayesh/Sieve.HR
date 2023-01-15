using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SectionController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public SectionController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<HR_SECTIONS> objList = unitOfWork.Section.SelectAll(orderBy: x => x.OrderBy(o => o.ID),includes:x=>x.HR_DEPARTMENT);
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            DropDownListFor_Create();
            HR_SECTIONS objDb = new HR_SECTIONS();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = unitOfWork.Section.SelectById(id.Value);
                return View(objDb);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_SECTIONS obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    Int64 AvailableNumberOfEmployee = unitOfWork.Section.AvailableNumberOfEmployee(obj.DEPT_ID);                    
                    if (obj.MAX_EMP_NO > AvailableNumberOfEmployee)
                    {
                        if (AvailableNumberOfEmployee == 0)
                        {
                            TempData["msg"] = SweetMessages.ShowInfo($"Maximum number of employee Already Crossed For This Department...!!");
                            return View(obj);
                        }
                        else
                        {
                            TempData["msg"] = SweetMessages.ShowInfo($"Maximum number of employee can not be higher then ({AvailableNumberOfEmployee})");
                            return View(obj);
                        }                        
                    }
                    double maxSalaryAvailable = unitOfWork.Section.AvailableLeftSalary(obj.DEPT_ID);
                    if (obj.MAX_SALARY > maxSalaryAvailable)
                    {
                        if (maxSalaryAvailable == 0)
                        {
                            TempData["msg"] = SweetMessages.ShowInfo($"Maximum Salary Already Crossed For This Department...!!");
                            return View(obj);
                        }
                        else
                        {
                            TempData["msg"] = SweetMessages.ShowInfo($"Maximum Salary can not be higher then ({maxSalaryAvailable})");
                            return View(obj);
                        }
                    }
                    unitOfWork.Section.Insert(obj);
                 
                }
                else
                {
                    Int64 AvailableNumberOfEmployee = unitOfWork.Section.AvailableNumberOfEmployee(obj.DEPT_ID);
                    if (obj.MAX_EMP_NO > AvailableNumberOfEmployee)
                    {
                        if (AvailableNumberOfEmployee == 0)
                        {
                            TempData["msg"] = SweetMessages.ShowInfo($"Maximum number of employee Already Crossed For This Department...!!");
                            return View(obj);
                        }
                        else
                        {
                            TempData["msg"] = SweetMessages.ShowInfo($"Maximum number of employee can not be higher then ({AvailableNumberOfEmployee})");
                            return View(obj);
                        }
                    }
                    double maxSalaryAvailable = unitOfWork.Section.AvailableLeftSalary(obj.DEPT_ID);
                    if (obj.MAX_SALARY > maxSalaryAvailable)
                    {
                        if (maxSalaryAvailable == 0)
                        {
                            TempData["msg"] = SweetMessages.ShowInfo($"Maximum Salary Already Crossed For This Department...!!");
                            return View(obj);
                        }
                        else
                        {
                            TempData["msg"] = SweetMessages.ShowInfo($"Maximum Salary can not be higher then ({maxSalaryAvailable})");
                            return View(obj);
                        }
                    }
                    unitOfWork.Section.Update(obj);
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
            ViewBag.DEPT_ID = unitOfWork.Department.SelectAll(includes:x => x.HR_COMPANY).Select(s => new SelectListItem() { Text = s.DEPT_NAME + "-" + s.HR_COMPANY.COMP_NAME, Value = s.ID.ToString() }).ToList();
        }
    }
}
