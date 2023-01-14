using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DutyRosterController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public DutyRosterController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_DUTY_ROSTER> objList = unitOfWork.DutyRoster.SelectAll(orderBy: x => x.OrderBy(o => o.ID));
            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            HR_DUTY_ROSTER objDb = new HR_DUTY_ROSTER();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = unitOfWork.DutyRoster.SelectById(id.Value);
                return View(objDb);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_DUTY_ROSTER obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    unitOfWork.DutyRoster.Insert(obj);
                }
                else
                {
                    unitOfWork.DutyRoster.Update(obj);
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
    }
}
