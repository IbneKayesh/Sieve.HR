using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DesignationController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public DesignationController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<HR_DESIGNATIONS> objList = unitOfWork.Designation.SelectAll(orderBy: x => x.OrderBy(o => o.ID));
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            DropDownListFor_Create();
            HR_DESIGNATIONS objDb = new HR_DESIGNATIONS();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = unitOfWork.Designation.SelectById(id.Value);
                return View(objDb);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_DESIGNATIONS obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    unitOfWork.Designation.Insert(obj);
                }
                else
                {
                    unitOfWork.Designation.Update(obj);
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
            ViewBag.PARENT_ID = unitOfWork.Designation.SelectAll().Select(s => new SelectListItem() { Text = s.SHORT_FORM, Value = s.ID.ToString() }).ToList();
        }
    }
}
