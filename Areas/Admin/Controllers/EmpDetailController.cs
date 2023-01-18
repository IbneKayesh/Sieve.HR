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
    public class EmpDetailController : Controller
    {
        //private readonly HRDbContext _context;
        //public EmpDetailController(HRDbContext context)
        //{
        //    _context = context;
        //}

        private readonly IUnitOfWork unitOfWork;
        public EmpDetailController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            //IEnumerable<HR_EMP_DETAIL> objList = _context.HR_EMP_DETAIL;

            IEnumerable<HR_EMP_DETAIL> objList = unitOfWork.EmpDetail.SelectAll(orderBy: x => x.OrderBy(o => o.ID));
            return View(objList);
        }
        
        public IActionResult Create(int? id)
        {
            HR_EMP_DETAIL objDb = new HR_EMP_DETAIL();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = unitOfWork.EmpDetail.SelectById(id.Value);
                return View(objDb);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EMP_DETAIL obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    unitOfWork.EmpDetail.Insert(obj);
                }
                else
                {                    
                    unitOfWork.EmpDetail.Update(obj);
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
        

        //public IActionResult Delete(int? id)
        //{
        //    var Deleterecord = _context.HR_EMP_DETAIL.Find(id);

        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        _context.HR_EMP_DETAIL.Remove(Deleterecord);
        //        _context.SaveChanges();
        //        TempData["ResultOk"] = "Data Deleted Successfully !";
        //        return RedirectToAction("Index");
        //    }

        //}

        //private void DropDownListFor_Create()
        //{
        //    ViewBag.GENDER_ID = new List<SelectListItem>() { new SelectListItem { Text = "Male", Value = "Male" },
        //                                                     new SelectListItem { Text = "Female", Value = "Female"},
        //                                                     new SelectListItem { Text = "Third Gender", Value = "Third Gender"}
        //                                                    };

        //    ViewBag.MARITAIL_STATUS = new List<SelectListItem>() { new SelectListItem { Text = "Married", Value = "Married" },
        //                                                     new SelectListItem { Text = "Unmarried", Value = "Unmarried"},
        //                                                     new SelectListItem { Text = "Divorce", Value = "Divorce"}
        //                                                    };
        //}

    }
}
