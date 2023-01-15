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
            IEnumerable<HR_SECTIONS> objList = unitOfWork.Section.SelectAll(orderBy: x => x.OrderBy(o => o.ID));
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
                        TempData["msg"] = SweetMessages.ShowInfo($"Maximum number of employee can be assigned ({AvailableNumberOfEmployee})");
                        return View(obj);
                    }

                    double maxSalary = unitOfWork.Section.AvailableLeftSalary(obj.ID, obj.MAX_SALARY);
                    if (maxSalary < 0)
                    {
                        TempData["msg"] = SweetMessages.ShowInfo($"Total Salary ({maxSalary}) of selected Department is less then you entered");
                        return View(obj);
                    }

                    else
                    {
                        unitOfWork.Section.Insert(obj);
                    }                   
                }
                else
                {
                    //Int64 AvailableNumberOfEmployee = unitOfWork.Section.AvailableNumberOfEmployee(obj.DEPT_ID);
                    //if (obj.MAX_EMP_NO > AvailableNumberOfEmployee)
                    //{
                    //    TempData["msg"] = SweetMessages.ShowInfo($"Maximum number of employee can be assigned ({AvailableNumberOfEmployee})");
                    //    return View(obj);
                    //}

                    //double maxSalary = unitOfWork.Section.AvailableLeftSalary(obj.ID, obj.MAX_SALARY);
                    //if (maxSalary < 0)
                    //{
                    //    TempData["msg"] = SweetMessages.ShowInfo($"Total Salary ({maxSalary}) of selected Department is less then you entered");
                    //    return View(obj);
                    //}
                    //unitOfWork.Company.Update(obj);
                }
               // _context.SaveChanges();
                TempData["ResultOk"] = "Record Added/Updated Successfully !";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        private void DropDownListFor_Create()
        {
            //ViewBag.DEPT_ID = _context.HR_DEPARTMENT.Select(s => new SelectListItem() { Text = s.DEPT_NAME + "-" + s.HR_COMPANY.COMP_NAME, Value = s.ID.ToString() }).ToList();

            ViewBag.DEPT_ID = unitOfWork.Department.SelectAll(includes:x => x.HR_COMPANY).Select(s => new SelectListItem() { Text = s.DEPT_NAME + "-" + s.HR_COMPANY.COMP_NAME, Value = s.ID.ToString() }).ToList();
        }
    }
}
