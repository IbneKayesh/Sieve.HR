using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmpRosterController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public EmpRosterController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index(int id)
        {
            IEnumerable<HR_EMP_ROSTER> objList = unitOfWork.EmpRoster.SelectAll(filter: x => x.EMP_ID == id);
            return View(objList);
        }
        public IActionResult Create(int id)
        {
            DropDownListFor_Create();
            HR_EMP_DETAIL emp = unitOfWork.EmpDetail.SelectById(id);
            if (emp == null)
            {
                TempData["msg"] = SweetMessages.ShowError($"No Employee found with the ID: {id}");
                return RedirectToAction(nameof(Index));
            }
            else
            {
                List<HR_EMP_JOB> empJob = unitOfWork.EmpJob.SelectAll(filter: x => x.EMP_ID == id).ToList();
                if (empJob.Count == 0)
                {
                    TempData["msg"] = SweetMessages.ShowError("Emplopyee Job placement is required to before assigning the Duty Roster");
                    return RedirectToAction(nameof(Index));
                }
                HR_EMP_ROSTER objDb = unitOfWork.EmpRoster.SelectById(id);
                if (objDb == null)
                {
                    objDb = new HR_EMP_ROSTER();
                    objDb.ID = 0;
                    objDb.EMP_ID = id;
                    objDb.FULL_NAME = emp.FULL_NAME;
                    objDb.SUPERVISOR_ID = empJob.First().VERIFIED_BY;
                    objDb.HEAD_ID = empJob.First().APPROVED_BY;
                }
                else
                {
                    objDb.ID = 1;
                }
                return View(objDb);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EMP_ROSTER obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    unitOfWork.EmpRoster.Insert(obj);
                }
                else
                {
                    unitOfWork.EmpRoster.Update(obj);
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
            ViewBag.ROSTER_ID = unitOfWork.DutyRoster.SelectListDutyRoster();
        }

    }
}
